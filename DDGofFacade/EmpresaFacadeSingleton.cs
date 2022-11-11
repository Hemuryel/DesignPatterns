using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDGofFacade
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade instance = null;

        private EmpresaFacadeSingleton()
        {

        }

        public static EmpresaFacade GetInstance()
        {
            if (instance == null){
                instance = new EmpresaFacade();
            }

            return instance;
        }
    }
}
