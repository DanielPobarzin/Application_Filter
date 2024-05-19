using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace FiltersApplication
{
    public partial class App : Application
	{
        public static Dictionary<int, double> PassageAshInactiveZonesThreeFields = new Dictionary<int, double>()
		{
			{ 1, 0.023 },
			{ 2, 0.022 },
			{ 3, 0.020 },
            { 4, 0.002 }
		};
		public static Dictionary<int, double> PassageAshInactiveZonesFourFields = new Dictionary<int, double>()
		{
			{ 1, 0.01 },
			{ 2, 0.009 },
			{ 3, 0.008 },
			{ 4, 0.001 }
		};
		public static Dictionary<int, Dictionary<int, double>> PassageAshInactiveZones = new Dictionary<int, Dictionary<int, double>>()
		{
			{ 3, PassageAshInactiveZonesThreeFields },
			{ 4, PassageAshInactiveZonesFourFields }
		};

		public static Dictionary<int, double> SquareVelocityDeviationAverageValueThreeFieldsCentralSupply = new Dictionary<int, double>()
		{
			{ 1, 0.150 },
			{ 2, 0.115 },
		};
		public static Dictionary<int, double> SquareVelocityDeviationAverageValueFourFieldsCentralSupply = new Dictionary<int, double>()
		{
			{ 1, 0.120 },
			{ 2, 0.096 },
		};
		public static Dictionary<int, Dictionary<int, double>> SquareVelocityDeviationAverageValueCentralSupply = new Dictionary<int, Dictionary<int, double>>()
		{
			{ 3, SquareVelocityDeviationAverageValueThreeFieldsCentralSupply },
			{ 4, SquareVelocityDeviationAverageValueFourFieldsCentralSupply }
		};

		public static Dictionary<double, double> SquareVelocityDeviationAverageValueThreeFieldsSupplyBelowOneGrid = new Dictionary<double, double>()
		{
			{ 0, 0.100 },
			{ 0.4, 0.079 },
			{ 0.8, 0.064 }
		};
		public static Dictionary<double, double> SquareVelocityDeviationAverageValueFourFieldsSupplyBelowOneGrid = new Dictionary<double, double>()
		{
			{ 0, 0.084 },
			{ 0.4, 0.070 },
			{ 0.8, 0.060 }
		};
		public static Dictionary<double, double> SquareVelocityDeviationAverageValueThreeFieldsSupplyBelowTwoGrid = new Dictionary<double, double>()
		{
			{ 0, 0.068 },
			{ 0.4, 0.053 },
			{ 0.8, 0.042 }
		};
		public static Dictionary<double, double> SquareVelocityDeviationAverageValueFourFieldsSupplyBelowTwoGrid = new Dictionary<double, double>()
		{
			{ 0, 0.053 },
			{ 0.4, 0.047 },
			{ 0.8, 0.042 }
		};

		public static Dictionary<int, Dictionary<double, double>> SquareVelocityDeviationAverageValueSupplyBelowOneGrid = new Dictionary<int, Dictionary<double, double>>()
		{
			{ 3, SquareVelocityDeviationAverageValueThreeFieldsSupplyBelowOneGrid },
			{ 4, SquareVelocityDeviationAverageValueFourFieldsSupplyBelowOneGrid }
		};
		public static Dictionary<int, Dictionary<double, double>> SquareVelocityDeviationAverageValueSupplyBelowTwoGrid = new Dictionary<int, Dictionary<double, double>>()
		{
			{ 3, SquareVelocityDeviationAverageValueThreeFieldsSupplyBelowTwoGrid },
			{ 4, SquareVelocityDeviationAverageValueFourFieldsSupplyBelowTwoGrid }
		};
		public static Dictionary<int, Dictionary<int, Dictionary<double, double>>> SquareVelocityDeviationAverageValueSupplyBelow = new Dictionary<int, Dictionary<int, Dictionary<double, double>>>()
		{
			{ 1, SquareVelocityDeviationAverageValueSupplyBelowOneGrid},
			{ 2, SquareVelocityDeviationAverageValueSupplyBelowTwoGrid}
		};

		public static double PassageAshSemiActiveZones = 0.05;
		public static double СoeffIncreasePassageWeakenedElectricField = 2.0;
		public static double СoefficientElectrodeType = 1.0;
		public static double MechanicalUnderburningFuel = 1.0;

		public static Dictionary<string, double> ProportionCarriedAshDuringSlagRemoval = new Dictionary<string, double>()
		{
			{ "Твердое шлакоудаление", 0.95 },
			{ "Жидкое шлакоудаление", 0.95 }
		};
	}
}
