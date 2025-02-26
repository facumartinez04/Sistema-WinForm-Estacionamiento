using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public class LabelsService
    {


		
		#region singleton
			private readonly static LabelsService _instance = new LabelsService();

			public static LabelsService Current
			{
				get
				{
					return _instance;
				}
			}

			private LabelsService()
			{
				//Implent here the initialization of your singleton
			}
			#endregion
		



    }
}
