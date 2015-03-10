using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    public class N_Odontograma
    {
        [DataMember]
        Boolean D11 { get; set; }
        [DataMember]
        Boolean D12 { get; set; }
        [DataMember]
        Boolean D13 { get; set; }
        [DataMember]
        Boolean D14 { get; set; }
        [DataMember]
        Boolean D15 { get; set; }
        [DataMember]
        Boolean D16 { get; set; }
        [DataMember]
        Boolean D17 { get; set; }
        [DataMember]
        Boolean D18 { get; set; }

        [DataMember]
        Boolean D21 { get; set; }
        [DataMember]
        Boolean D22 { get; set; }
        [DataMember]
        Boolean D23 { get; set; }
        [DataMember]
        Boolean D24 { get; set; }
        [DataMember]
        Boolean D25 { get; set; }
        [DataMember]
        Boolean D26 { get; set; }
        [DataMember]
        Boolean D27 { get; set; }
        [DataMember]
        Boolean D28 { get; set; }

        [DataMember]
        Boolean D31 { get; set; }
        [DataMember]
        Boolean D32 { get; set; }
        [DataMember]
        Boolean D33 { get; set; }
        [DataMember]
        Boolean D34 { get; set; }
        [DataMember]
        Boolean D35 { get; set; }
        [DataMember]
        Boolean D36 {get; set; }
        [DataMember]
        Boolean D37 { get; set; }
        [DataMember]
        Boolean D38 { get; set; }

        [DataMember]
        Boolean D41 { get; set; }
        [DataMember]
        Boolean D42 { get; set; }
        [DataMember]
        Boolean D43 { get; set; }
        [DataMember]
        Boolean D44 { get; set; }
        [DataMember]
        Boolean D45 { get; set; }
        [DataMember]
        Boolean D46 { get; set; }
        [DataMember]
        Boolean D47 { get; set; }
        [DataMember]
        Boolean D48 { get; set; }
        
        public N_Odontograma( String[] vOdontograma)
        {
            if (vOdontograma[0].CompareTo("F")==0){
                this.D11 = false;
            }
            else if (vOdontograma[0].CompareTo("V")==0){
                this.D11 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D12 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D12 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D13 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D13 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D14 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D14 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D15 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D15 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D16 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D16 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D17 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D17 = true;
            }

            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D18 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D18 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D21 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D21 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D22 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D22 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D23 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D23 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D24 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D24 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D25 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D25 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D26 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D26 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D27 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D27 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D28 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D28 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D31 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D31 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D32 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D32 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D33 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D33 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D34 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D34 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D35 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D35 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D36 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D36 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D37 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D37 = true;
            }

            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D48 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D48 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D41 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D41 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D42 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D42 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D43 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D43 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D44 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D44 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D45 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D45 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D46 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D46 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D47 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D47 = true;
            }
            if (vOdontograma[0].CompareTo("F") == 0)
            {
                this.D48 = false;
            }
            else if (vOdontograma[0].CompareTo("V") == 0)
            {
                this.D48 = true;
            }

        }
    }
}
