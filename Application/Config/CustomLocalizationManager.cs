using FiltersApplication.ViewModel;
using Microsoft.OData.UriParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;
using Telerik.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using Telerik.Windows.Controls.FieldList;
using Telerik.Windows.Controls.Primitives;

namespace FiltersApplication.Config
{
    public class CustomLocalizationManager : LocalizationManager
    {
        public override string GetStringOverride(string key)
        {
			switch (key)
            {
                case "GridViewGroupPanelText":
                    return "Для группировки перетащите заголовок столбца в эту область.";
                //---------------------- RadGridView Filter Dropdown items texts: 
                case "GridViewClearFilter":
                    return "Очистить фильтр";
                case "GridViewFilterShowRowsWithValueThat":
                    return "Отображение значений с условием:";
                case "GridViewFilterSelectAll":
                    return "Показать все";
                case "GridViewFilterContains":
                    return "Содержит";
				case "GridViewFilterDoesNotContain":
					return "Не содержит";
				case "GridViewFilterEndsWith":
                    return "Заканчивается";
                case "GridViewFilterIsContainedIn":
                    return "Включено в";
                case "GridViewFilterIsEqualTo":
                    return "То же самое";
                case "GridViewFilterIsGreaterThan":
                    return "Больше, чем";
                case "GridViewFilterIsGreaterThanOrEqualTo":
                    return "Больше или равно";
                case "GridViewFilterIsLessThan":
                    return "Меньше, чем";
                case "GridViewFilterIsLessThanOrEqualTo":
                    return "Меньше или равно";
                case "GridViewFilterIsNotEqualTo":
                    return "Неравный";
                case "GridViewFilterStartsWith":
                    return "Начинается с";
                case "GridViewFilterAnd":
                    return "И";
                case "GridViewFilter":
                    return "Фильтр";
				case "GridViewFilterIsNotContainedIn":
					return "Не содержится в";
				case "GridViewFilterMatchCase":
					return "Учитывать регистр";
				case "GridViewFilterOr":
					return "Или";
				case "GridViewFilterIsNull":
					return "Равно нулю";
				case "GridViewFilterIsNotNull":
					return "Не равно нулю";
				case "GridViewFilterIsEmpty":
					return "Пуст";
				case "GridViewFilterIsNotEmpty":
					return "Не пуст";
				case "GridViewFilterDistinctValueNull":
					return "[null]";
				case "GridViewFilterDistinctValueStringEmpty":
					return "[пуст]";
				//---------------------- RadGridView items texts: 
				case "GridViewSearchPanelTopText":
					return "Поиск по таблице";
				case "GridViewGroupPanelTopText":
					return "Заголовок группы";
				case "GridViewGroupPanelTopTextGrouped":
					return "Сгруппирован по:";
				case "GridViewColumnsSelectionButtonTooltip":
					return "Выбор столбца";
				case "GridViewNewRowPositionButtonTooltip":
					return "Добавить";
				case "GroupColumn":
					return "Столбец группы";
				case "SortAdditionalColumn":
					return "Сортировка дополнительного столбца";
				case "SortColumn":
					return "Сортировка столбца";
				case "GridViewAlwaysVisibleNewRow":
					return "Добавить новый элемент";

			}
			return base.GetStringOverride(key);
        }
    }
}