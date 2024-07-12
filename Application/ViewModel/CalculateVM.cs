using FiltersApplication.Model;
using FiltersApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;
using FiltersApplication.View;
using SharpDX;
using System.Threading;

namespace FiltersApplication.ViewModel
{
	class CalculateVM : ViewModelBase
	{
		private CalculatingProcess _result;
		private string patternBrandFilter = @"[а-яА-Я\d]";
		private string patternBrandFuel = @"[а-яА-Я]";
		private string patternStation = @"[\d]";
		public bool continueCalc;
		private Filter _selectedFilter;
		private Station _currentPropertyStation;
		private ObservableCollection<Fuel> _selectedFuels;
		public CalculatingProcess Result
		{
			get { return _result; }
			set
			{
				_result = value;
				OnPropertyChanged("Result");
			}
		}
		public Filter SelectFilter
		{
			get { return _selectedFilter; }
			set
			{
				_selectedFilter = value; 
				OnPropertyChanged("SelectFilter");
			}
		}
		public ObservableCollection<Fuel> SelectFuels
		{
			get { return _selectedFuels; }
			set
			{
				_selectedFuels = value;
				OnPropertyChanged("SelectFuels");
			}
		}
		public Station CurrentPropertyStation
		{
			get { return _currentPropertyStation; }
			set
			{
				_currentPropertyStation = value;
				OnPropertyChanged("CurrentPropertyStation");
			}
		}
		public bool Execute;

		private ICommand _calculateCommand;
		public Dictionary<string, CalculatingProcess> Results;
		//public ObservableCollection<CalculatingProcess> Results { get; set; }
		public CalculateVM()
		{
			
		}
		public ICommand CalculateCommand
		{
			get
			{
				_calculateCommand ??= new RelayCommand(execute: p => CaclulateButton_Click(p));
				return _calculateCommand;
			}
		}

		public bool Initialize(object obj)
		{
			Result = new CalculatingProcess();
			Results = new Dictionary<string, CalculatingProcess>();
			Result.AshConcentrationEntranceMthField = new List<double>();
			Result.OptimalAshShakingMode = new List<double>();
			try
			{
				SelectFilter = (Regex.IsMatch(GlobalSingletonFilterModel.Instance.SelectedFilter.BrandFilter.ToString(), patternBrandFilter)) ?
				GlobalSingletonFilterModel.Instance.SelectedFilter : null;
				CurrentPropertyStation = (Regex.IsMatch(GlobalSingletonFilterModel.Instance.CurrentParametersStation.ExhaustGasTemperature.ToString(), patternStation)) ?
				GlobalSingletonFilterModel.Instance.CurrentParametersStation : null;
				SelectFuels = (Regex.IsMatch(GlobalSingletonFilterModel.Instance.SelectedFuels[0].BrandFuel.ToString(), patternBrandFuel)) ?
				GlobalSingletonFilterModel.Instance.SelectedFuels : null;
				if (SelectFilter == null || CurrentPropertyStation == null || SelectFuels == null)
					throw new Exception();
			}
			catch
			{
				MessageBox.Show("Не определены данные для расчета. Проверьте, что вы указали все необходимые данные.",
				"Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
				Results.Clear(); Execute = false; return false;
			}
			return true;
		}

		public void CaclulateButton_Click(object obj)
		{
			Results.Clear();
				foreach (Fuel fuel in SelectFuels)
				{
					 Results.Add(fuel.BrandFuel, MainProgram(fuel, CurrentPropertyStation, SelectFilter));
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
				CDegreeAshCapture(fuel);
				if (continueCalc)
				{
					CAmountAshFormedProductsMechanicalUnderburning(CurrentPropertyStation, fuel);
					CAshConcentrationEntranceToFirstField();
					CPassageAshFirstField(SelectedFilter);
					CDegreeAshCaptureFirstField();
					COptimalValueDustCapacity(fuel);
					CAreaDepositionOneField(SelectedFilter);
					CNumberGasesEnteringOneField(CurrentPropertyStation);
					CAshConcentrationEntranceMthField(SelectedFilter);
					COptimalAshShakingMode();
				}
				
			return Result;
		}

		private void CVolumetricGasConsumption(Fuel SelectedFuel, Station CurrentPropertyStation)
		{
			Result.VolumetricGasConsumption = CurrentPropertyStation.FuelConsumption * (SelectedFuel.TheoreticalVolumeGas + 1.016 * (CurrentPropertyStation.AirSuction - 1) *
					SelectedFuel.TheoreticalAirVolume) * (273 + CurrentPropertyStation.ExhaustGasTemperature) / 273;
		}
		private void CFlueGasVelocity(Filter SelectedFilter, Station CurrentPropertyStation)
		{
			Result.FlueGasVelocity = Result.VolumetricGasConsumption / (CurrentPropertyStation.NumberSmokePumps * SelectedFilter.AreaActiveSection);
		}
		private void CEffectiveStrength(Fuel SelectedFuel)
		{
			Result.EffectiveStrength = SelectedFuel.CoefficientReverseCrown * SelectedFuel.ElectricFieldStrength;
		}
		private void CTrateDriftAshParticles(Fuel SelectedFuel)
		{
			Result.TrateDriftAshParticles = 0.25 * Math.Pow(Result.EffectiveStrength, 2)  * SelectedFuel.MedianDiameterAsh;
		}
		private void CHeightCoefficientElectrode(Filter SelectedFilter)
		{
			Result.HeightCoefficientElectrode = 7.5 / SelectedFilter.ElectrodeHeight;
		}
		private void CCoeffSecondaryEntrainmentTrappedAsh(Filter SelectedFilter)
		{
			Result.CoeffSecondaryEntrainmentTrappedAsh = Result.HeightCoefficientElectrode * App.СoefficientElectrodeType * SelectedFilter.СoefficientShakingMode * 
				(1 - 0.25 * (Result.FlueGasVelocity - 1));
		}
		private void CParameterAshCollectionUNIFORMVelocityField(Filter SelectedFilter)
		{
			Result.ParameterAshCollectionUNIFORMVelocityField = 0.2 * Result.CoeffSecondaryEntrainmentTrappedAsh *
				Math.Sqrt(Result.TrateDriftAshParticles / Result.FlueGasVelocity) * SelectedFilter.NumberFields * 
				SelectedFilter.ActiveFieldLength / SelectedFilter.DistanceCPDevices;
		}
		private void CAshEmissionUniformVelocityField()
		{
			Result.AshEmissionUniformVelocityField = Math.Exp(-Result.ParameterAshCollectionUNIFORMVelocityField);
		}
		private void CDegreeAshCaptureUNIFORMVelocityField()
		{
			Result.DegreeAshCaptureUNIFORMVelocityField = 1 - Result.AshEmissionUniformVelocityField;
		}
		private void CCoeffRelativeIncreaseInfluenceUnevenness()
		{
			Result.CoeffRelativeIncreaseInfluenceUnevenness = 0.125 * (1 + Result.ParameterAshCollectionUNIFORMVelocityField ) * Result.ParameterAshCollectionUNIFORMVelocityField;
		}
		private void CRelativeHeightLiftShaft(Station CurrentPropertyStation, Filter SelectedFilter)
		{
			double[] ListValue = { 0, 0.4, 0.8 };
			Result.RelativeHeightLiftingShaft = CurrentPropertyStation.HeightLiftShaft / SelectedFilter.ElectrodeHeight;
			Result.RelativeHeightLiftingShaft = FindClosestValue(Result.RelativeHeightLiftingShaft, ListValue);
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
		}
		private void CPassageAshTakingAccountGasLeaksZones(Station CurrentPropertyStation, Filter SelectedFilter)
		{
			Result.PassageAshInactiveZones = App.PassageAshInactiveZones[SelectedFilter.NumberFields][CurrentPropertyStation.SchemeBunkerPartitions];
			Result.PassageAshTakingAccountGasLeaksZones = (1 - Result.PassageAshInactiveZones - App.PassageAshSemiActiveZones) *
				Result.PassageAshTakingAccountUNEVENNESSFieldVelocity + App.PassageAshSemiActiveZones * Result.PassageAshTakingAccountUNEVENNESSFieldVelocity *
				App.СoeffIncreasePassageWeakenedElectricField + Result.PassageAshInactiveZones;
		}
		private void CDegreeAshCapture(Fuel SelectedFuel)
		{
			Result.DegreeAshCapture = 1 - Result.PassageAshTakingAccountGasLeaksZones;
			if (Result.DegreeAshCapture < 0.99)
			{
				MessageBoxResult result = MessageBox.Show($"Степень улавливания золы для топлива типа {SelectedFuel.BrandFuel} ниже минимально допустимого значения. Желаете продолжить расчет?",
					"Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
				if (result == MessageBoxResult.No)
				{
					continueCalc = false;
					Result = null;
					Results.Clear();
					MessageBox.Show("Вам следует выбрать другие исходные данные, так как результат показывает неэффективность выбранного фильтра.", "Предупреждение",
					MessageBoxButton.OK, MessageBoxImage.Warning);
					return;
				}
			}
			continueCalc = true;
			return;
		}
		private void CAmountAshFormedProductsMechanicalUnderburning(Station CurrentPropertyStation, Fuel SelectedFuel)
		{
			Result.AmountAshFormedProductsMechanicalUnderburning = 10 * CurrentPropertyStation.FuelConsumption *
				(App.ProportionCarriedAshDuringSlagRemoval[CurrentPropertyStation.SlagRemoval] * SelectedFuel.AshContent + 
				App.MechanicalUnderburningFuel * SelectedFuel.LowerHeatCombustion / 32.68);
		}
		private void CAshConcentrationEntranceToFirstField()
		{
			Result.AshConcentrationEntranceToFirstField = Result.AmountAshFormedProductsMechanicalUnderburning / Result.VolumetricGasConsumption;
		}
		private void CPassageAshFirstField(Filter SelectedFilter)
		{
			double deg = 1 / SelectedFilter.NumberFields;
			Result.PassageAshFirstField = Math.Pow(Result.PassageAshTakingAccountGasLeaksZones, 1.0 / SelectedFilter.NumberFields);
		}
		private void CDegreeAshCaptureFirstField()
		{
			Result.DegreeAshCaptureFirstField = 1 - Result.PassageAshFirstField;
		}
		private void COptimalValueDustCapacity(Fuel SelectedFuel)
		{
			Result.OptimalValueDustCapacity = 3.14 - 0.25 * SelectedFuel.ElectricalResistanceAsh;
		}
		private void CAreaDepositionOneField(Filter SelectedFilter)
		{
			Result.AreaDepositionOneField = SelectedFilter.TotalDepositionArea / SelectedFilter.NumberFields;
		}
		private void CNumberGasesEnteringOneField(Station CurrentPropertyStation)
		{
			Result.NumberGasesEnteringOneField = Result.VolumetricGasConsumption / CurrentPropertyStation.NumberSmokePumps;
		}
		private void CAshConcentrationEntranceMthField(Filter SelectedFilter)
		{
			for (int i = 1; i <= SelectedFilter.NumberFields; i++)
			{
				Result.AshConcentrationEntranceMthField.Add(Result.AshConcentrationEntranceToFirstField * Math.Pow(Result.PassageAshFirstField, i - 1));
			}
		}
		private void COptimalAshShakingMode()
		{
			int i = 0;
			foreach (double AshConcentration in Result.AshConcentrationEntranceMthField)
			{
				i++;
				Result.OptimalAshShakingMode.Add(16.7 * Result.AreaDepositionOneField * Result.OptimalValueDustCapacity /
				(Result.NumberGasesEnteringOneField * AshConcentration * Result.DegreeAshCaptureFirstField));
			}
		}
	}
}

