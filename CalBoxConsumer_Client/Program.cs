﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalBoxConsumer_Client.BoxCalServiceReference;

namespace CalBoxConsumer_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new BoxCalServiceReference.BoxCalServiceClient("BasicHttpBinding_IBoxCalService"))
            {
                Console.WriteLine("Udregning af Boksen volumen:");
                
                Console.WriteLine("Boksens volumen er:" + client.GetVolume(2,2,2));

                Console.WriteLine("Udregning af Boksens manglende side:");

                Console.WriteLine("Boksens manglende side er:" + client.GetSide(8,2,2));

                client.InsertBoxCalRequest("volume",8,2,2,2);

                BoxCalRequest[] allrequest = client.GetAllRequest();
                foreach (var reg in allrequest)
                {
                    Console.WriteLine(reg.Request);
                }
            }

            Console.ReadLine();
        }
    }
}
