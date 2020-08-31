using System;
using System.Collections.Generic;
using System.Linq;

namespace listDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<command_type> tlist = init_t_list();
            List<Command_order> olist = init_List();
            var res=olist.Where(z=>tlist.Any(x=>x.id.Equals(z.type_id)));

            var res2=olist.Where(z=>tlist.All(x=>!x.id.Equals(z.type_id)));

        foreach (var item in res)
        {
            Console.WriteLine(item.Command_name);
        }
        Console.WriteLine("--------");
          foreach (var item in res2)
        {
            Console.WriteLine(item.Command_name);
        }

        }

        static List<command_type> init_t_list()
        {
            List<command_type> t_list = new List<command_type>();

            t_list.Add(new command_type { id = 1, type_name = "1" });
            t_list.Add(new command_type { id = 5, type_name = "5" });

            return t_list;
        }
        static List<Command_order> init_List()
        {
            List<Command_order> co_list = new List<Command_order>();
            co_list.Add(new Command_order() { command_id = 1, Command_name = "1", type_id = 1 });
            co_list.Add(new Command_order() { command_id = 2, Command_name = "2", type_id = 2 });
            co_list.Add(new Command_order() { command_id = 3, Command_name = "3", type_id = 3 });
            co_list.Add(new Command_order() { command_id = 4, Command_name = "4", type_id = 4 });
            co_list.Add(new Command_order() { command_id = 5, Command_name = "5", type_id = 5 });
            co_list.Add(new Command_order() { command_id = 6, Command_name = "6", type_id = 6 });
            co_list.Add(new Command_order() { command_id = 7, Command_name = "7", type_id = 7 });


            return co_list;
        }
    }
    class command_type
    {
        public int id { get; set; }
        public string type_name { get; set; }
    }
    class Command_order
    {
        public int command_id { get; set; }
        public int type_id { get; set; }
        public string Command_name { get; set; }
    }
}
