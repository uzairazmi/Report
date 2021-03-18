using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReportHCL.API
{
    public class ReportDataController : ApiController
    {

        [HttpGet]
        public int[] GetReport(int id)
        {
            // int N = 10;
            int[] arr = new int[id];
            //arr[0] = 1;
            //arr[1] = 1;
            //arr[2] = 1;
            //arr[3] = 3;
            //1 ,1 ,1 ,3 ,5 ,9 ,17 ,31 ,57 ,105 ,
            for (int i = 0; i < id; i++)
            {
                if (i < 3)
                {
                    arr[i] = 1;
                }
                else
                {
                    int j = i - 1, sum = 0;
                    // count = 0,
                    // Find the sum of all
                    for (int k = 0; k < 3; k++)
                    {
                        sum = sum + arr[j];
                        j--;
                    }
                    // Find the value of
                    // sum at i position
                    arr[i] = sum;
                }

            }
            return arr;
        }

        [HttpGet]
        public int GetReportById(int id,int div, int pos)
        {
            //int N = 10;
            //int div = 3;
            // int position = 1;
            int[] arr = new int[id];
            // arr[0] = 1;
            // arr[1] = 1;
            // arr[2] = 1;
            for (int i = 0; i < id; i++)
            {
                if (i < 3)
                {
                    arr[i] = 1;
                }
                else
                {
                    int j = i - 1, sum = 0;
                    // count = 0,
                    // Find the sum of all
                    for (int k = 0; k < 3; k++)
                    {
                        sum = sum + arr[j];
                        j--;
                    }

                    // Find the value of
                    // sum at i position
                    arr[i] = sum;
                }
                   
            }
            int[] arrDevision = new int[id];
            int val = 0;
            int r1 = 1;
            for (int t = 0; t < id; t++)
            {
                val = arr[t];
                if (val % div == 0)
                {
                    arrDevision[r1] = arr[t];
                    r1++;
                }     
            }
            //Console.WriteLine(arrDevision[position]);
            //arrDevision[0] = 0
            //arrDevision[1] = 3
            //arrDevision[2] = 9
            return arrDevision[pos];

        }
    }
}
