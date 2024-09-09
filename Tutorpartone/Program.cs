using System;

namespace Tutorpartone
{
    class Program
    {
        static void Main()
        {
            // Membuat instance dari BasicBagianDua
            BasicBagianDua basicBagianDua = new BasicBagianDua();
            basicBagianDua.ShowVariables();

            // Membuat instance dari BasicBagianSatu
            BasicBagianSatu basicBagianSatu = new BasicBagianSatu();
            basicBagianSatu.ShowVariables();
            // Jika BasicBagianSatu tidak memiliki metode lain yang bisa dipanggil
            // Anda bisa menghilangkan pemanggilan BasicBagianSatu jika tidak perlu
        }
    }
}
