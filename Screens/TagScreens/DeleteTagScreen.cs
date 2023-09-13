using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando uma tag");
            Console.WriteLine("Qual o Id da tag que deseja excluir? ");
            var id = Console.ReadLine();

            Console.WriteLine("-------------");
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag removida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível remover a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
