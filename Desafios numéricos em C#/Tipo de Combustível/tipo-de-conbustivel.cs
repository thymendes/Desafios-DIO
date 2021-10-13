using System; 

class URI {

    static void Main(string[] args) { 
      
      int alcool = 0;
      int gasolina = 0;
      int diesel = 0;
      int fim = 4;
      int option;

            do
            {
                
                 option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                    alcool +=1;
                    break;
                     
                    case 2:
                    gasolina +=1;
                    break;
                      
                    case 3:
                    diesel +=1;
                    break;
                        
                    case 4:
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                        break;
                        
                    default:
                        continue;
                        
                }
            }
       
         while ( option !=4) ;

    }

}