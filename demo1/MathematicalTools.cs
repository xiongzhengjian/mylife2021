using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class MathematicalTools
    {
        //方法是可以自我调用的，调用的过程就是递归，根据这一特性制作阶乘工具
        public long factorial(int num) {
            long result;
            if (num == 1)
            {
                return 1;
            }
            else {
                result = factorial(num - 1) * num;
                return result;
            }

        }

        //组合方法
        public long combination(int AL,int AH) {
                     
            long A = factorial(AL);
            long result = A / factorial(AH);
            return result;
            
        }
    }
}
