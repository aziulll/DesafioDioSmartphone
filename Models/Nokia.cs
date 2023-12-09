namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp, string modeloCell)
        {

            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\"no seu celular - \"{modeloCell}\"");
            
            Console.WriteLine("Instalando...");
          
            Console.WriteLine($"\"{nomeApp}\" foi instalado com suceso! Clique para poder utiliza-lo");
           
        }
    }
}


