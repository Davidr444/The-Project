using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        void addNanny(Nanny nanny);
        void deleteNanny(Nanny nanny);
        void updatingNanny(Nanny nanny);

        void addMother(Mother mother);
        void deleteMother(Mother mother);
        void updatingMother(Mother mother);

        void addChild(Child child);
        void deleteChild(Child child);
        void updatingChild(Child child);

        void addContract(Contract contract);
        void deleteContract(Contract contract);
        void updatingContract(Contract contract);

        List<Nanny> GetAllNanny();
        List<Mother> GetAllMother();
        List<Child> GetAllChild();
        List<Contract> GetAllContract();
    }
}
