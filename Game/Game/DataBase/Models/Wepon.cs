using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataBase.Models
{
    public abstract class Wepon
    {
        public abstract string ShootRangeInKm();
        public abstract string ReloaadInTime();
    }
    public class Ak47 : Wepon
    {
        public override string ShootRangeInKm()
        {
            return $"{2}Km";
        }
        public override string ReloaadInTime()
        {
            return $"{8}Sec";
        }
    }
    public class M4 : Wepon
    {
        public override string ShootRangeInKm()
        {
            return $"{3}Km";
        }
        public override string ReloaadInTime()
        {
            return $"{8}Sec";
        }
    }
}
