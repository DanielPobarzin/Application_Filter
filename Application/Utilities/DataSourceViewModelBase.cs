using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApplication.Utilities
{
	public abstract class DataSourceViewModelBase : ViewModelBase
	{
		protected virtual string SilverlightPath
		{
			get
			{
				return "..\\..\\..\\data\\{0}";
			}
		}

		protected virtual string WpfPath
		{
			get
			{
				return "..\\..\\..\\data\\{0}";
			}
		}


		protected virtual void GetData(string fileName)
		{
			string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(this.WpfPath, fileName));
			using (StreamReader fileReader = new StreamReader(path))
			{
				this.GetDataCompleted(this.ParseData(fileReader));
			}
		}

		protected abstract void GetDataCompleted(IEnumerable data);

		protected abstract IEnumerable ParseData(TextReader dataReader);
	}
}




//protected virtual void GetData(string fileName)
//{
//	Uri uri = new Uri(string.Format(this.WpfPath, fileName), UriKind.RelativeOrAbsolute);
//	System.Windows.Resources.StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(uri);
//	using (StreamReader fileReader = new StreamReader(streamInfo.Stream))
//	{
//		this.GetDataCompleted(this.ParseData(fileReader));
//	}
//}