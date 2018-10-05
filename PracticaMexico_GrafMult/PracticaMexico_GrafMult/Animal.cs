using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMexico_GrafMult
{
    class Animal
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public string Audio { get; set; }
        public string Video { get; set; }
        public string PDF { get; set; }

        public int ExisteAudio
        {
            get
            {
                if (Audio.Length != 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    class DB_Animal : DbContext
    {
        public DbSet<Animal> Animales { get; set; }
    }
}
