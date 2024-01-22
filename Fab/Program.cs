using Fab.Lib.Pars;
using System;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Blocks));

        using (FileStream fileStream = new FileStream("test.xml", FileMode.Open))
        {
            Blocks blocks = (Blocks)serializer.Deserialize(fileStream);

            if (blocks != null)
            {
                foreach (var block in blocks.BlockList)
                {
                    Console.WriteLine('\n' + block.ChatName + " " + block.Guid + "\n");
                    foreach (var input in block.Inputs.InputList)
                    {
                        Console.WriteLine(input.Name + " " + input.Type + "\n");
                        foreach(var guid in input.OutputsGUI.OutputGuidList)
                            Console.WriteLine(guid + " ");
                        Console.WriteLine("\n");
                    }
                    foreach (var output in block.Outputs.OutputList)
                    {
                        Console.WriteLine(output.Name + " " + output.Type + "\n");
                        foreach (var guid in output.InputsGUI.InputGuidList)
                            Console.WriteLine(guid + " ");
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}