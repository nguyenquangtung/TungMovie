using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungMovie
{
    class PaymentStrategy
    {


        public interface IPaymentStrategy
        {
            void ExecutePayment(string a, string b, int amount);
        }


        public class MoMoPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string a, string b, int amount)
            {
 
            }
        }

        public class VNPayPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string a, string b, int amount)
            {
  
            }
        }

        public class QRPayPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string a, string b, int amount)
            {
 
            }
        }

        public class PaymentContext
        {
            private IPaymentStrategy PaymentStrategy;


            public void SetPaymentStrategy(IPaymentStrategy strategy)
            {
                this.PaymentStrategy = strategy;
            }

            public void ExecutePayment(string a, string b, int amount)
            {
                PaymentStrategy.ExecutePayment(a, b, amount);
            }
        }
    }
}

