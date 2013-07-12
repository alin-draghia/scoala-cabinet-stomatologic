using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet
{
    public partial class Pacient
    {
        public String DisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Nume, this.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
    }

    public partial class Medic
    {
        public String DisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Nume, this.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
    }

    public partial class Programare
    {
        public String PacientDisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Pacient.Nume, this.Pacient.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public String MedicDisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Medic.Nume, this.Medic.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public String InterventieDisplayName
        {
            get
            {
                try
                {
                    return this.TipIntervenie.Denumire;
                }
                catch (Exception)
                {
                    return string.Empty;
                }               
            }
        }
    }

    public partial class Interventie
    {

        public String PacientDisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Pacient.Nume, this.Pacient.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public String MedicDisplayName
        {
            get
            {
                try
                {
                    return string.Join(", ", this.Medic.Nume, this.Medic.Prenume);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public String InterventieDisplayName
        {
            get
            {
                try
                {
                    return this.TipIntervenie.Denumire;
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public decimal PretDisplay
        {
            get
            {
                try
                {
                    return this.Pret.Pret1;
                }
                catch (Exception)
                {
                    return 0.0M;
                }
            }
        }

        public String getDummy()
        {
            return "salihaa";
        }
    }

    public partial class TipIntervenie
    {
        decimal PretDisplay
        {
            get
            {
                try
                {
                    return (from p in this.Pret
                            orderby p.DataInceput descending
                            select p.Pret1).First();
                }
                catch (Exception)
                {
                    return 0.0M;
                }
            }
        }
    }

    public partial class Pret
    {
        public String InterventieDisplayName
        {
            get
            {
                return this.TipIntervenie.Denumire;
            }
        }
    }
}
