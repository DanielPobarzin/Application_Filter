using FiltersApplication.Model;
using FiltersApplication.Utilities;
using MediaFoundation;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.RichTextBoxCommands;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace FiltersApplication.ViewModel
{
	class CalculateVM : Utilities.ViewModelBase
	{
		private CalculatingProcess _result;
		public CalculatingProcess Result
		{
			get { return _result; }
			set
			{
				_result = value;
				OnPropertyChanged("Result");
			}
		}
		
		private ICommand _calculateCommand;
		public Filter SelectedFilter = GlobalSingletonFilterModel.Instance.SelectedFilter;
		public Station CurrentPropertyStation = GlobalSingletonFilterModel.Instance.CurrentParametersStation;
		public ObservableCollection<Fuel> SelectedFuels = GlobalSingletonFilterModel.Instance.SelectedFuels;
		public ObservableCollection<CalculatingProcess> Results {  get; set; }
		public CalculateVM()
		{
			Result ??= new CalculatingProcess();
			Results ??= new ObservableCollection<CalculatingProcess>();
			Result.AshConcentrationEntranceMthField ??= new List<double>();
			Result.OptimalAshShakingMode ??= new List<double>();
		}
		public ICommand CalculateCommand
		{
			get
			{
				_calculateCommand ??= new RelayCommand(execute: p => CaclulateButton_Click(p));
				return _calculateCommand;
			}
		}
		public void CaclulateButton_Click(object obj)
		{
			foreach(Fuel fuel in SelectedFuels)
			{
				Results.Add(MainProgram(fuel, CurrentPropertyStation, SelectedFilter));
			}
			
		}
		private CalculatingProcess MainProgram(Fuel fuel, Station CurrentPropertyStation, Filter SelectedFilter)
		{
				CVolumetricGasConsumption(fuel, CurrentPropertyStation);
				CFlueGasVelocity(SelectedFilter, CurrentPropertyStation);
				CEffectiveStrength(fuel);
				CTrateDriftAshParticles(fuel);
				CHeightCoefficientElectrode(SelectedFilter);
				CCoeffSecondaryEntrainmentTrappedAsh(SelectedFilter);
				CParameterAshCollectionUNIFORMVelocityField(SelectedFilter);
				CAshEmissionUniformVelocityField();
				CDegreeAshCaptureUNIFORMVelocityField();
				CCoeffRelativeIncreaseInfluenceUnevenness();
				CRelativeHeightLiftShaft(CurrentPropertyStation, SelectedFilter);
				CPassageAshTakingAccountUNEVENNESSFieldVelocity(CurrentPropertyStation, SelectedFilter);
				CPassageAshTakingAccountGasLeaksZones(CurrentPropertyStation, SelectedFilter);
				CDegreeAshCapture();
				CAmountAshFormedProductsMechanicalUnderburning(CurrentPropertyStation, fuel);
				CAshConcentrationEntranceToFirstField();
				CPassageAshFirstField(SelectedFilter);
				CDegreeAshCaptureFirstField();
				COptimalValueDustCapacity(fuel);
				CAreaDepositionOneField(SelectedFilter);
				CNumberGasesEnteringOneField(CurrentPropertyStation);
				CAshConcentrationEntranceMthField(SelectedFilter);
				COptimalAshShakingMode();
			return Result;
		}

		private void CVolumetricGasConsumption(Fuel SelectedFuel, Station CurrentPropertyStation)
		{
			Result.VolumetricGasConsumption = CurrentPropertyStation.FuelConsumption * (SelectedFuel.TheoreticalVolumeGas + 1.016 * (CurrentPropertyStation.AirSuction - 1) *
					SelectedFuel.TheoreticalAirVolume) * (273 + CurrentPropertyStation.ExhaustGasTemperature) / 273;
			MessageBox.Show($" Объемный расход газа: {Result.VolumetricGasConsumption} = {CurrentPropertyStation.FuelConsumption} * ({SelectedFuel.TheoreticalVolumeGas} + 1.016 * ({CurrentPropertyStation.AirSuction} - 1) * {SelectedFuel.TheoreticalAirVolume}) * (273 + {CurrentPropertyStation.ExhaustGasTemperature}) / 273;");
			return;
		}
		private void CFlueGasVelocity(Filter SelectedFilter, Station CurrentPropertyStation)
		{
			Result.FlueGasVelocity = Result.VolumetricGasConsumption / (CurrentPropertyStation.NumberSmokePumps * SelectedFilter.AreaActiveSection);
			MessageBox.Show($"Скорость дымовых газов: {Result.FlueGasVelocity} ={Result.VolumetricGasConsumption}/ ({CurrentPropertyStation.NumberSmokePumps}* {SelectedFilter.AreaActiveSection}) ");
			return;
		}

		private void CEffectiveStrength(Fuel SelectedFuel)
		{
			Result.EffectiveStrength = SelectedFuel.CoefficientReverseCrown * SelectedFuel.ElectricFieldStrength;
			MessageBox.Show($"Эффективная напряженность: {Result.EffectiveStrength} = {SelectedFuel.CoefficientReverseCrown} * {SelectedFuel.ElectricFieldStrength}");
			return;
		}

		private void CTrateDriftAshParticles(Fuel SelectedFuel)
		{
			Result.TrateDriftAshParticles = 0.25 * Math.Pow(Result.EffectiveStrength, 2)  * SelectedFuel.MedianDiameterAsh;
			MessageBox.Show($"Скорость дрейфа частиц: {Result.TrateDriftAshParticles} = 0.25 * {Math.Pow(Result.EffectiveStrength, 2)} * {SelectedFuel.MedianDiameterAsh}");
			return;
		}
		private void CHeightCoefficientElectrode(Filter SelectedFilter)
		{
			Result.HeightCoefficientElectrode = 7.5 / SelectedFilter.ElectrodeHeight;
			MessageBox.Show($"Коэффициент высоты электрода: {Result.HeightCoefficientElectrode} = 7.5 / {SelectedFilter.ElectrodeHeight}");
			return;
		}
		private void CCoeffSecondaryEntrainmentTrappedAsh(Filter SelectedFilter)
		{
			Result.CoeffSecondaryEntrainmentTrappedAsh = Result.HeightCoefficientElectrode * App.СoefficientElectrodeType * SelectedFilter.СoefficientShakingMode * 
				(1 - 0.25 * (Result.FlueGasVelocity - 1));
			MessageBox.Show($"Коэффициент вторичного уноса золы: {Result.CoeffSecondaryEntrainmentTrappedAsh} = {Result.HeightCoefficientElectrode} * {App.СoefficientElectrodeType} * {SelectedFilter.СoefficientShakingMode} * (1 - 0.25 * ({Result.FlueGasVelocity} - 1)); ");
			return;
		}
		private void CParameterAshCollectionUNIFORMVelocityField(Filter SelectedFilter)
		{
			Result.ParameterAshCollectionUNIFORMVelocityField = 0.2 * Result.CoeffSecondaryEntrainmentTrappedAsh *
				Math.Sqrt(Result.TrateDriftAshParticles / Result.FlueGasVelocity) * SelectedFilter.NumberFields * 
				SelectedFilter.ActiveFieldLength / SelectedFilter.DistanceCPDevices;
			MessageBox.Show($"Параметр золоулавливания при равномерном поле скоростей: {Result.ParameterAshCollectionUNIFORMVelocityField} = 0.2 * {Result.CoeffSecondaryEntrainmentTrappedAsh} * Math.Sqrt({Result.TrateDriftAshParticles} / {Result.FlueGasVelocity}) * {SelectedFilter.NumberFields} * {SelectedFilter.ActiveFieldLength}/ {SelectedFilter.DistanceCPDevices}");
			return;
		}
		private void CAshEmissionUniformVelocityField()
		{
			Result.AshEmissionUniformVelocityField = Math.Exp(-Result.ParameterAshCollectionUNIFORMVelocityField);
			MessageBox.Show($"Проскок золы при равномерном поле скоростей:{Result.AshEmissionUniformVelocityField} = Math.Exp({-Result.ParameterAshCollectionUNIFORMVelocityField})");
			return;
		}
		private void CDegreeAshCaptureUNIFORMVelocityField()
		{
			Result.DegreeAshCaptureUNIFORMVelocityField = 1 - Result.AshEmissionUniformVelocityField;
			MessageBox.Show($"Степень улавливания золы при РАВНОМЕРНОМ поле скоростей: {Result.DegreeAshCaptureUNIFORMVelocityField} = 1 - {Result.AshEmissionUniformVelocityField}");
			return;
		}
		private void CCoeffRelativeIncreaseInfluenceUnevenness()
		{
			Result.CoeffRelativeIncreaseInfluenceUnevenness = 0.125 * (1 + Result.ParameterAshCollectionUNIFORMVelocityField ) * Result.ParameterAshCollectionUNIFORMVelocityField;
			MessageBox.Show($"Коэффициент относительного увеличения влияния неравномерности: {Result.CoeffRelativeIncreaseInfluenceUnevenness} = 0.125 * (1 + {Result.ParameterAshCollectionUNIFORMVelocityField} ) * {Result.ParameterAshCollectionUNIFORMVelocityField}");
			return;
		}
		private void CRelativeHeightLiftShaft(Station CurrentPropertyStation, Filter SelectedFilter)
		{
			double[] ListValue = { 0, 0.4, 0.8 };
			Result.RelativeHeightLiftingShaft = CurrentPropertyStation.HeightLiftShaft / SelectedFilter.ElectrodeHeight;
			Result.RelativeHeightLiftingShaft = FindClosestValue(Result.RelativeHeightLiftingShaft, ListValue);
			MessageBox.Show($"Относительная высота подъемной шахты: {Result.RelativeHeightLiftingShaft}");
			return;
		}
		static double FindClosestValue(double target, double[] values)
		{
			double closest = values[0];
			double minDifference = Math.Abs(target - values[0]);

			foreach (var value in values)
			{
				double difference = Math.Abs(target - value);
				if (difference < minDifference)
				{
					minDifference = difference;
					closest = value;
				}
			}
			return closest;
		}
		private void CPassageAshTakingAccountUNEVENNESSFieldVelocity(Station CurrentPropertyStation, Filter SelectedFilter)
		{
			Result.SquareVelocityDeviationAverageValue = (CurrentPropertyStation.TypeFlueGasSupply == "Подвод дымовых газов снизу" ) ?
				App.SquareVelocityDeviationAverageValueSupplyBelow[CurrentPropertyStation.NumberGrids][SelectedFilter.NumberFields][Result.RelativeHeightLiftingShaft] :
				App.SquareVelocityDeviationAverageValueCentralSupply[SelectedFilter.NumberFields][CurrentPropertyStation.NumberGrids];
			Result.PassageAshTakingAccountUNEVENNESSFieldVelocity = (1 + Result.CoeffRelativeIncreaseInfluenceUnevenness * 
				Math.Pow(Result.SquareVelocityDeviationAverageValue, 2)) * Result.AshEmissionUniformVelocityField;
			MessageBox.Show($"Значение квадрата отклонения скорости от среднего значения:{Result.SquareVelocityDeviationAverageValue}; " +
				$"Проскок золы через электрофильтр с учетом НЕРАВНОМЕРНОСТИ поля скоростей: {Result.PassageAshTakingAccountUNEVENNESSFieldVelocity} = (1 + {Result.CoeffRelativeIncreaseInfluenceUnevenness} * Math.Pow({Result.SquareVelocityDeviationAverageValue}, 2)) * {Result.AshEmissionUniformVelocityField}");
			return;
		}

		private void CPassageAshTakingAccountGasLeaksZones(Station CurrentPropertyStation, Filter SelectedFilter)
		{
			Result.PassageAshInactiveZones = App.PassageAshInactiveZones[SelectedFilter.NumberFields][CurrentPropertyStation.SchemeBunkerPartitions];
			Result.PassageAshTakingAccountGasLeaksZones = (1 - Result.PassageAshInactiveZones - App.PassageAshSemiActiveZones) *
				Result.PassageAshTakingAccountUNEVENNESSFieldVelocity + App.PassageAshSemiActiveZones * Result.PassageAshTakingAccountUNEVENNESSFieldVelocity *
				App.СoeffIncreasePassageWeakenedElectricField + Result.PassageAshInactiveZones;
			MessageBox.Show($"ϕн: {Result.PassageAshInactiveZones}: " +
				$"Проскок золы через электрофильтр с учетом протечек газов через неактивные и полуактивные зоны: {Result.PassageAshTakingAccountGasLeaksZones} = (1 - {Result.PassageAshInactiveZones} - {App.PassageAshSemiActiveZones}) *{Result.PassageAshTakingAccountUNEVENNESSFieldVelocity} + {App.PassageAshSemiActiveZones} * {Result.PassageAshTakingAccountUNEVENNESSFieldVelocity} * {App.СoeffIncreasePassageWeakenedElectricField} + {Result.PassageAshInactiveZones}");
			return;
		}
		private void CDegreeAshCapture()
		{
			Result.DegreeAshCapture = 1 - Result.PassageAshTakingAccountGasLeaksZones;
			if (Result.DegreeAshCapture < 0.99)
			{
				MessageBoxResult result = MessageBox.Show($"Степень улавливания золы равна {Result.DegreeAshCapture}, что ниже минимально допустимого значения. Желаете продолжить расчет?",
					"Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
				if (result == MessageBoxResult.No)
				{
					Result = null;
					Results.Clear();
					throw new Exception("Вам следует выбрать другие исходные данные, так как результат показывает неэффективность выбранного фильтра.");
				}
			}
			return;
		}
		private void CAmountAshFormedProductsMechanicalUnderburning(Station CurrentPropertyStation, Fuel SelectedFuel)
		{
			Result.AmountAshFormedProductsMechanicalUnderburning = 10 * CurrentPropertyStation.FuelConsumption *
				(App.ProportionCarriedAshDuringSlagRemoval[CurrentPropertyStation.SlagRemoval] * SelectedFuel.AshContent + 
				App.MechanicalUnderburningFuel * SelectedFuel.LowerHeatCombustion / 32.68);
			MessageBox.Show($"количество образующейся золы и продуктов механического недожога топлива: {Result.AmountAshFormedProductsMechanicalUnderburning} = 10 * {CurrentPropertyStation.FuelConsumption} *({App.ProportionCarriedAshDuringSlagRemoval[CurrentPropertyStation.SlagRemoval]} * {SelectedFuel.AshContent} + {App.MechanicalUnderburningFuel} * {SelectedFuel.LowerHeatCombustion} / 32.68);");
			return;
		}
		
		private void CAshConcentrationEntranceToFirstField()
		{
			Result.AshConcentrationEntranceToFirstField = Result.AmountAshFormedProductsMechanicalUnderburning / Result.VolumetricGasConsumption;
			MessageBox.Show($"Концентрация золы на входе в первое поле :{Result.AshConcentrationEntranceToFirstField} = {Result.AmountAshFormedProductsMechanicalUnderburning} / {Result.VolumetricGasConsumption}");
			return;
		}

		private void CPassageAshFirstField(Filter SelectedFilter)
		{
			double deg = 1 / SelectedFilter.NumberFields;
			Result.PassageAshFirstField = Math.Pow(Result.PassageAshTakingAccountGasLeaksZones, 1.0 / SelectedFilter.NumberFields);
			MessageBox.Show($"проскок  золы в  первом поле :{Result.PassageAshFirstField} = {Result.PassageAshTakingAccountGasLeaksZones}^ ({deg})");
			return;
		}
		private void CDegreeAshCaptureFirstField()
		{
			Result.DegreeAshCaptureFirstField = 1 - Result.PassageAshFirstField;
			MessageBox.Show($"степень улавливания золы в первом поле : {Result.DegreeAshCaptureFirstField} = 1 - {Result.PassageAshFirstField}");
			return;
		}
		private void COptimalValueDustCapacity(Fuel SelectedFuel)
		{
			Result.OptimalValueDustCapacity = 3.14 - 0.25 * SelectedFuel.ElectricalResistanceAsh;
			MessageBox.Show($"Пылеемкость: {Result.OptimalValueDustCapacity} = 3.14 - 0.25 * {SelectedFuel.ElectricalResistanceAsh}");
			return;
		}
		private void CAreaDepositionOneField(Filter SelectedFilter)
		{
			Result.AreaDepositionOneField = SelectedFilter.TotalDepositionArea / SelectedFilter.NumberFields;
			MessageBox.Show($"Площадь осаждения 1 фильтра: {Result.AreaDepositionOneField} = {SelectedFilter.TotalDepositionArea} / {SelectedFilter.NumberFields}");
			return;
		}
		private void CNumberGasesEnteringOneField(Station CurrentPropertyStation)
		{
			Result.NumberGasesEnteringOneField = Result.VolumetricGasConsumption / CurrentPropertyStation.NumberSmokePumps;
			MessageBox.Show($"Количество газов, поступающих в одно поле: {Result.NumberGasesEnteringOneField} = {Result.VolumetricGasConsumption} / {CurrentPropertyStation.NumberSmokePumps}");
			return;
		}
		private void CAshConcentrationEntranceMthField(Filter SelectedFilter)
		{
			for (int i = 1; i <= SelectedFilter.NumberFields; i++)
			{
				Result.AshConcentrationEntranceMthField.Add(Result.AshConcentrationEntranceToFirstField * Math.Pow(Result.PassageAshFirstField, i - 1));
				MessageBox.Show($" Для {i} поля Концентрация золы на входе: {Result.AshConcentrationEntranceToFirstField * Math.Pow(Result.PassageAshFirstField, i - 1)} = {Result.AshConcentrationEntranceToFirstField} * Math.Pow({Result.PassageAshFirstField}, {i - 1} ");
			}

			return;
		}

		private void COptimalAshShakingMode()
		{
			int i = 0;
			foreach (double AshConcentration in Result.AshConcentrationEntranceMthField)
			{
				i++;
				Result.OptimalAshShakingMode.Add(16.7 * Result.AreaDepositionOneField * Result.OptimalValueDustCapacity /
				(Result.NumberGasesEnteringOneField * AshConcentration * Result.DegreeAshCaptureFirstField));
				MessageBox.Show($"Для {i} поля оптимальный режим встряхивания: {16.7 * Result.AreaDepositionOneField * Result.OptimalValueDustCapacity / (Result.NumberGasesEnteringOneField * AshConcentration * Result.DegreeAshCaptureFirstField)} = 16.7 * {Result.AreaDepositionOneField} * {Result.OptimalValueDustCapacity} / ({Result.NumberGasesEnteringOneField} * {AshConcentration} * {Result.DegreeAshCaptureFirstField}));");

			}
			return;
		}


	}
}

