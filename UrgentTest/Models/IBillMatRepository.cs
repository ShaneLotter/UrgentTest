using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrgentTest.ViewModels;

namespace UrgentTest.Models
{
    public interface IBillMatRepository
    {
        BillofMaterial GenerateBill(ShapesViewModel shapes);

        BillofMaterial ThrowAbort();
    }
}
