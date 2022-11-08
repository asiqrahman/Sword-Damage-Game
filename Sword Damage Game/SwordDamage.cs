using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword_Damage_Game
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public int Roll;
        public decimal MagiMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;
        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagiMultiplier) + BASE_DAMAGE + FLAME_DAMAGE;
        }
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagiMultiplier = 1.75M;
            }
            else
            {
                MagiMultiplier = 1M;
            }
            CalculateDamage();
        }
        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
