using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Microsoft.OData.Edm;
using System.Security.Policy;
using System.Reflection.Metadata;
using SharpDX.Direct3D9;
using System.Security.Principal;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Controls.Charting;
using Telerik.Windows.Documents.Fixed.Model.Data;
using System.Windows.Media.Media3D;

namespace FiltersApplication.Model
{
    public class Filter : INotifyPropertyChanged
	    {
		private string pattern = @"[а-яА-Я\d]";
		private string brandFilter; // Модель фильтра
		private int id;
		private double areaActiveSection; // Площадь активного сечения
		private double activeFieldLength; // Активная длина поля
		private double totalDepositionArea; // Общая площадь осаждения
		private double weight; // Масса 
		private double length; // Длина
		private double height; // Высота
		private double width; // Ширина
		private double electrodeHeight; // Высота электрода
		private double coefficientShakingMode; // Коэффициент типа встряхивания
		private int numberFields; // Число полей
		private double distanceCPDevices; // Расстояние между коронующим и осадительным устройствами

		[Key]
		public int ID
		{
			get { return id; }
			set { id = value;
				OnPropertyChanged("ID");
			}
		}
		public string BrandFilter
		{
			get { return brandFilter; }
			set
			{
                try
                {

                    if (Regex.IsMatch(value, pattern))
                    {

                        brandFilter = value.ToUpper();
						OnPropertyChanged("BrandFilter");
					}
                    else
                    {
                        MessageBox.Show("Формат названия модели фильтра не соответствует требованиям.", "Ошибка формата данных", MessageBoxButton.OK, MessageBoxImage.Error);
                        brandFilter = null;

					}
                }
                catch
                {
                    MessageBox.Show("Нельзя оставлять пустые поля при изменении данных!", "Неверный формат данных", MessageBoxButton.OK, MessageBoxImage.Warning);
					brandFilter = null;
				}
			}
		}

        public double AreaActiveSection
        {
            get { return areaActiveSection; }
            set
            {
                areaActiveSection = value;
                OnPropertyChanged("AreaActiveSection");
            }
        }
        public double ActiveFieldLength
        {
            get { return activeFieldLength; }
            set
            {
                activeFieldLength = value;
                OnPropertyChanged("ActiveFieldLength");
            }
        }
        public double TotalDepositionArea
        {
            get { return totalDepositionArea; }
            set
            {
                totalDepositionArea = value;
                OnPropertyChanged("TotalDepositionArea");
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                OnPropertyChanged("Length");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged("Width");
            }
        }
        public double ElectrodeHeight
        {
            get { return electrodeHeight; }
            set
            {
                electrodeHeight = value;
                OnPropertyChanged("ElectrodeHeight");
            }
        }
        public double СoefficientShakingMode
        {
            get { return coefficientShakingMode; }
            set
            {
                coefficientShakingMode = value;
                OnPropertyChanged("СoefficientShakingMode");
            }
        }
        public int NumberFields
        {
            get { return numberFields; }
            set
            {
                numberFields = value;
                OnPropertyChanged("NumberFields");
            }
        }
        public double DistanceCPDevices
        {
            get { return distanceCPDevices; }
            set
            {
                distanceCPDevices = value;
                OnPropertyChanged("DistanceCPDevices");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class Fuel : INotifyPropertyChanged
    {
		private string pattern = @"[а-яА-Я\d]";
		private string brandFuel; // Модель топлива (тип и месторождение)
		private int id;
		private string type; // Марка топлива
		private double lowerHeatCombustion; // Низшая теплота сгорания
		private double sulfurContent; // Серность
		private double ashContent; // Зольность
		private double humidity; // Влажность
		private double nContent; // Содержание N
		private double theoreticalAirVolume; // Теоретический объем воздуха
		private double theoreticalVolumeGas; // Теоретический объем газа
		private double theoreticalVolumeWaterVapor; // Теоретический объем водяных паров
		private double medianDiameterAsh; // Медианный диаметр золы
		private double electricFieldStrength; // Напряженность электрического поля
		private double coefficientReverseCrown; // Коэффициент, учитывающий влияние обратной короны
		private double electricalResistanceAsh; // Электрическое сопротивление золы

		[Key]
		public int ID
		{
			get { return id; }
			set { id = value;
				OnPropertyChanged("ID");
			}
		}
		public string BrandFuel
        {
            get { return brandFuel; }
            set
            {
				try
				{

					if (Regex.IsMatch(value, pattern))
					{

						brandFuel = value;
						OnPropertyChanged("BrandFuel");
					}
					else
					{
						MessageBox.Show("Формат названия марки топлива не соответствует требованиям.", "Ошибка формата данных", MessageBoxButton.OK, MessageBoxImage.Error);
						brandFuel = null;

					}
				}
				catch
				{
					MessageBox.Show("Нельзя оставлять пустые поля при изменении данных!", "Неверный формат данных", MessageBoxButton.OK, MessageBoxImage.Warning);
					brandFuel = null;
				}
			}
        }
        public string Type
        {
            get { return type; }
            set
            {
				try
				{

					if (Regex.IsMatch(value, pattern))
					{

						type = value.ToUpper();
						OnPropertyChanged("Type");
					}
					else
					{
						MessageBox.Show("Формат названия типа топлива не соответствует требованиям.", "Ошибка формата данных", MessageBoxButton.OK, MessageBoxImage.Error);
						type = null;

					}
				}
				catch
				{
					MessageBox.Show("Нельзя оставлять пустые поля при изменении данных!", "Неверный формат данных", MessageBoxButton.OK, MessageBoxImage.Warning);
					type = null;
				}
            }
        }
        public double LowerHeatCombustion
        {
            get { return lowerHeatCombustion; }
            set
            {
                lowerHeatCombustion = value;
                OnPropertyChanged("LowerHeatCombustion");
            }
        }
        public double SulfurContent
        {
            get { return sulfurContent; }
            set
            {
                sulfurContent = value;
                OnPropertyChanged("SulfurContent");
            }
        }
        public double AshContent
        {
            get { return ashContent; }
            set
            {
                ashContent = value;
                OnPropertyChanged("AshContent");
            }
        }
        public double Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                OnPropertyChanged("Humidity");
            }
        }
        public double NContent
        {
            get { return nContent; }
            set
            {
                nContent = value;
                OnPropertyChanged("NContent");
            }
        }
        public double TheoreticalAirVolume
        {
            get { return theoreticalAirVolume; }
            set
            {
                theoreticalAirVolume = value;
                OnPropertyChanged("TheoreticalAirVolume");
            }
        }
        public double TheoreticalVolumeGas
        {
            get { return theoreticalVolumeGas; }
            set
            {
                theoreticalVolumeGas = value;
                OnPropertyChanged("TheoreticalVolumeGas");
            }
        }
        public double TheoreticalVolumeWaterVapor
        {
            get { return theoreticalVolumeWaterVapor; }
            set
            {
                theoreticalVolumeWaterVapor = value;
                OnPropertyChanged("TheoreticalVolumeWaterVapor");
            }
        }
        public double MedianDiameterAsh
        {
            get { return medianDiameterAsh; }
            set
            {
                medianDiameterAsh = value;
                OnPropertyChanged("MedianDiameterAsh");
            }
        }
        public double ElectricFieldStrength
        {
            get { return electricFieldStrength; }
            set
            {
                electricFieldStrength = value;
                OnPropertyChanged("ElectricFieldStrength");
            }
        }
        public double CoefficientReverseCrown
        {
            get { return coefficientReverseCrown; }
            set
            {
                coefficientReverseCrown = value;
                OnPropertyChanged("CoefficientReverseCrown");
            }
        }
        public double ElectricalResistanceAsh
        {
            get { return electricalResistanceAsh; }
            set
            {
                electricalResistanceAsh = value;
                OnPropertyChanged("ElectricalResistanceAsh");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class Station : INotifyPropertyChanged
    {
		private string? mill; // Мельница
		private double fuelConsumption; // Расход топлива
		private string? slagRemoval; // Тип шлакоудаления
		private double exhaustGasTemperature; // Температура уходящих газов
		private int numberSmokePumps; // Количество дымососов
		private double airSuction; // Присосы
		private  string typeFlueGasSupply; // Тип подвода газа
		private int numberGrids; // Число решеток
		private int schemeBunkerPartitions; // Схема бункерной перегородки
		private double heightLiftShaft; // Высота подъемной шахты

		public string Mill
		{
			get { return mill; }
			set
			{
                mill = value;
				OnPropertyChanged("Mill");
			}
		}
        public double FuelConsumption
		{
			get { return fuelConsumption; }
			set
			{
				try 
                {

				    fuelConsumption = value;
				    OnPropertyChanged("FuelConsumption");
				}
				catch
				{
			        MessageBox.Show("Проверьте формат заполнения данных!", "Неверный формат данных", MessageBoxButton.OK, MessageBoxImage.Warning);
					fuelConsumption = 0;
		        }
			}
		}
		public string SlagRemoval
		{
			get { return slagRemoval; }
			set
			{
				slagRemoval = value;
				OnPropertyChanged("SlagRemoval");
			}
		}
		public  double ExhaustGasTemperature
		{
			get { return exhaustGasTemperature; }
			set
			{		
					exhaustGasTemperature = value;
					OnPropertyChanged("ExhaustGasTemperature");
				
			}
		}
		public int NumberSmokePumps
		{
			get { return numberSmokePumps;}
			set
			{

					numberSmokePumps = value;
					OnPropertyChanged("NumberSmokePumps");
			}
		}
		public double AirSuction
		{
			get { return airSuction; }
			set
			{
				airSuction = value;
				OnPropertyChanged("AirSuction");
			}
		}
		public string TypeFlueGasSupply
		{
			get { return typeFlueGasSupply; }
			set
			{
				typeFlueGasSupply = value;
				OnPropertyChanged("TypeFlueGasSupply");
			}
		}
		public int NumberGrids
		{
			get { return numberGrids; }
			set
			{
				numberGrids = value;
				OnPropertyChanged("NumberGrids");
			}
		}
		public int SchemeBunkerPartitions
		{
			get { return schemeBunkerPartitions; }
			set
			{
				schemeBunkerPartitions = value;
				OnPropertyChanged("SchemeBunkerPartitions");
			}
		}
		public double HeightLiftShaft
		{
			get { return heightLiftShaft; }
			set
			{
				heightLiftShaft = value;
				OnPropertyChanged("HeightLiftShaft");
			}
		}
		

		public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
	}
	public class CalculatingProcess
    {
		private string pattern = @"[а-яА-Я\d]";
		private double volumetricGasConsumption; // Объемный расход газа
		private double flueGasVelocity; // Скорость дымовых газов
		private double trateDriftAshParticles; // Скорость дрейфа частиц золы 
		private double effectiveStrength; // Эффективная напряженность электрического поля
		private double coeffSecondaryEntrainmentTrappedAsh; // Коэффициент вторичного уноса уловленной золы
		private double heightCoefficientElectrode; // Коэффициент высоты электрода
		private double parameterAshCollectionUNIFORMVelocityField; // Параметр золоулавливания при РАВНОМЕРНОМ поле скоростей 
		private double ashEmissionUniformVelocityField; // Проскок золы при равномерном поле скоростей 
		private double degreeAshCaptureUNIFORMVelocityField; // Степень улавливания золы при РАВНОМЕРНОМ поле скоростей 
		private double passageAshTakingAccountUNEVENNESSFieldVelocity; // Проскок золы через электрофильтр с учетом НЕРАВНОМЕРНОСТИ поля 
		private double coeffRelativeIncreaseInfluenceUnevenness; // Коэффициент относительного увеличения влияния неравномерности
		private double squareVelocityDeviationAverageValue; // Значение квадрата отклонения скорости от среднего значения 
		private double relativeHeightLiftingShaft; //  Относительная высота подъемной шахты
		private double passageAshTakingAccountGasLeaksZones; // Проскок золы через электрофильтр с учетом протечек газов через зоны 
		private double passageAshInactiveZones; // Проскок золы через неактивные зоны 
		private double degreeAshCapture; // Степень улавливания золы
		private double ashConcentrationEntranceToFirstField; // Концентрация золы на входе в первое поле 
		private double amountAshFormedProductsMechanicalUnderburning; // Kоличество образующейся золы и продуктов механического недожога топлива
		private double passageAshFirstField; // проскок золы в первом поле 
		private double degreeAshCaptureFirstField; // степень улавливания золы в первом поле 
		private List<double> optimalAshShakingMode;  // Оптимальный режим встряхивания золы для каждого поля
		private double optimalValueDustCapacity;  // Оптимальное значение пылеемкости 
		private double areaDepositionOneField; // Площадь осаждения одного поля 
		private double numberGasesEnteringOneField; // Количество газов, поступающих в одно поле  
		private List<double> ashConcentrationEntranceMthField; //Концентрация золы на входе в m-тое поле

		public double VolumetricGasConsumption
		{
			get { return volumetricGasConsumption; }
			set
			{
                if (value > 0) { volumetricGasConsumption = value; OnPropertyChanged("VolumetricGasConsumption"); }
                else { volumetricGasConsumption = 0; MessageBox.Show("Значение объемного расхода не может быть отрицательным! Пересмотрите данные.", "Ошибка расчета", MessageBoxButton.OK, MessageBoxImage.Stop); }
			}
		}
		public double FlueGasVelocity
		{
			get { return flueGasVelocity; }
			set
			{
                if (value < 0) { flueGasVelocity = 0; MessageBox.Show("Значение скорости дымовых газов не может быть отрицательным! Пересмотрите данные.", "Ошибка расчета", MessageBoxButton.OK, MessageBoxImage.Stop); }
                else { flueGasVelocity = value; OnPropertyChanged("FlueGasVelocity"); }
			}
		}
		public double EffectiveStrength
		{
			get { return effectiveStrength; }
			set
			{
				effectiveStrength = value;
				OnPropertyChanged("EffectiveStrength");
			}
		}
		public double TrateDriftAshParticles
		{
			get { return trateDriftAshParticles; }
			set
			{
				trateDriftAshParticles = value;
				OnPropertyChanged("TrateDriftAshParticles");
			}
		}
		public double HeightCoefficientElectrode
		{
			get { return heightCoefficientElectrode; }
			set
			{
				heightCoefficientElectrode = value;
				OnPropertyChanged("HeightCoefficientElectrode");
			}
		}
		public double CoeffSecondaryEntrainmentTrappedAsh
		{
			get { return coeffSecondaryEntrainmentTrappedAsh; }
			set
			{
				coeffSecondaryEntrainmentTrappedAsh = value;
				OnPropertyChanged("CoeffSecondaryEntrainmentTrappedAsh");
			}
		}
		public double ParameterAshCollectionUNIFORMVelocityField
		{
			get { return parameterAshCollectionUNIFORMVelocityField; }
			set
			{
				parameterAshCollectionUNIFORMVelocityField = value;
				OnPropertyChanged("ParameterAshCollectionUNIFORMVelocityField");
			}
		}
		public double AshEmissionUniformVelocityField
		{
			get { return ashEmissionUniformVelocityField; }
			set
			{
				ashEmissionUniformVelocityField = value;
				OnPropertyChanged("AshEmissionUniformVelocityField");
			}
		}
		public double DegreeAshCaptureUNIFORMVelocityField
		{
			get { return degreeAshCaptureUNIFORMVelocityField; }
			set
			{
				degreeAshCaptureUNIFORMVelocityField = value;
				OnPropertyChanged("DegreeAshCaptureUNIFORMVelocityField");
			}
		}
		public double PassageAshTakingAccountUNEVENNESSFieldVelocity
		{
			get { return passageAshTakingAccountUNEVENNESSFieldVelocity; }
			set
			{
				passageAshTakingAccountUNEVENNESSFieldVelocity = value;
				OnPropertyChanged("PassageAshTakingAccountUNEVENNESSFieldVelocity");
			}
		}
		public double CoeffRelativeIncreaseInfluenceUnevenness
		{
			get { return coeffRelativeIncreaseInfluenceUnevenness; }
			set
			{
				coeffRelativeIncreaseInfluenceUnevenness = value;
				OnPropertyChanged("CoeffRelativeIncreaseInfluenceUnevenness");
			}
		}
		public double SquareVelocityDeviationAverageValue
		{
			get { return squareVelocityDeviationAverageValue; }
			set
			{
				squareVelocityDeviationAverageValue = value;
				OnPropertyChanged("SquareVelocityDeviationAverageValue");
			}
		}
		public double RelativeHeightLiftingShaft
		{
			get { return relativeHeightLiftingShaft; }
			set
			{
				relativeHeightLiftingShaft = value;
				OnPropertyChanged("RelativeHeightLiftingShaft");
			}
		}
		public double PassageAshTakingAccountGasLeaksZones
		{
			get { return passageAshTakingAccountGasLeaksZones; }
			set
			{
				passageAshTakingAccountGasLeaksZones = value;
				OnPropertyChanged("PassageAshTakingAccountGasLeaksZones");
			}
		}
		public double PassageAshInactiveZones
		{
			get { return passageAshInactiveZones; }
			set
			{
				passageAshInactiveZones = value;
				OnPropertyChanged("PassageAshInactiveZones");
			}
		}
		public double DegreeAshCapture
		{
			get { return degreeAshCapture; }
			set
			{
				degreeAshCapture = value;
				OnPropertyChanged("DegreeAshCapture");
			}
		}
		public double AshConcentrationEntranceToFirstField
		{
			get { return ashConcentrationEntranceToFirstField; }
			set
			{
				ashConcentrationEntranceToFirstField = value;
				OnPropertyChanged("AshConcentrationEntranceToFirstField");
			}
		}
		public double AmountAshFormedProductsMechanicalUnderburning
		{
			get { return amountAshFormedProductsMechanicalUnderburning; }
			set
			{
				amountAshFormedProductsMechanicalUnderburning = value;
				OnPropertyChanged("AmountAshFormedProductsMechanicalUnderburning");
			}
		}
		public double PassageAshFirstField
		{
			get { return passageAshFirstField; }
			set
			{
				passageAshFirstField = value;
				OnPropertyChanged("PassageAshFirstField");
			}
		}
		public double DegreeAshCaptureFirstField
		{
			get { return degreeAshCaptureFirstField; }
			set
			{
				degreeAshCaptureFirstField = value;
				OnPropertyChanged("PassageAshFirstField");
			}
		}
		public List<double> OptimalAshShakingMode
		{
			get { return optimalAshShakingMode; }
			set
			{
				optimalAshShakingMode = value;
				OnPropertyChanged("OptimalAshShakingMode");
			}
		}
		public double OptimalValueDustCapacity
		{
			get { return optimalValueDustCapacity; }
			set
			{
				optimalValueDustCapacity = value;
				OnPropertyChanged("OptimalValueDustCapacity");
			}
		}
		public double AreaDepositionOneField
		{
			get { return areaDepositionOneField; }
			set
			{
				areaDepositionOneField = value;
				OnPropertyChanged("AreaDepositionOneField");
			}
		}
		public double NumberGasesEnteringOneField
		{
			get { return numberGasesEnteringOneField; }
			set
			{
				numberGasesEnteringOneField = value;
				OnPropertyChanged("NumberGasesEnteringOneField");
			}
		}
		public List<double> AshConcentrationEntranceMthField
		{
			get { return ashConcentrationEntranceMthField; }
			set
			{
				ashConcentrationEntranceMthField = value;
				OnPropertyChanged("AshConcentrationEntranceMthField");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}


	}
}
