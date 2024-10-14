using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.Domain.Observer
{
    public interface IFormObserver
    {
        void Update(Form form);
    }
}
