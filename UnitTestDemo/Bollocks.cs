using System;

namespace UnitTestDemo
{
    public class Bollocks
    {
        public int bollNum { get; set; }
        public string bollString { get; set; }

        // assigns values to properties
        public Bollocks(int pBollNum, string pBollString){
            this.bollNum = pBollNum;
            bollString = pBollString;
        }

        // method that returns bollNum summed with the parameter value
        public int AddTo(int n){
            return bollNum + n;
        } 
 
        // method that DIVIDES bollNum BY 
        // the parameter value and returns the dividend

        public int DivBy(int n){
            try
            {
                if(n == 0)
                {
                    throw new DivideByZeroException();
                }
                else 
                {
                    return bollNum / n;
                }
            }
            catch (System.Exception)
            {
                
                throw new Exception("something went wrong");
            }
        }
        // method that returns the modulud of dividing bollNum BY 
        // the parameter value
        public int ModBy(int n){
            try
            {
                if(n == 0)
                {
                    throw new DivideByZeroException();
                }
                else 
                {
                    return bollNum & n;
                }
            }
            catch (System.Exception)
            {
                
                throw new Exception("something went wrong");
            }
        }
    }
}
