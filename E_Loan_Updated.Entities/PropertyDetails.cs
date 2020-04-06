using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
   public class PropertyDetails
    {
        public virtual int PropertId { get; set; }
        public virtual string AcresOfLand { get; set; }
        public virtual double LandValueInDoller { get; set; }
        public virtual string ProduceOnLand { get; set; }
        public virtual string AppraisedBy { get; set; }
        public virtual DateTime ValuationDate { get; set; }
        public virtual string FieldRepresentative { get; set; }
        public virtual string PropertyCountry { get; set; }
        public virtual string PropertyState { get; set; }
    }
}
