using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_UI
{
    class BigInt
    {
        public int[] number;
        public int size;
        private bool sign;

        #region Constructors

        /// <summary>
        /// Constructors..
        /// </summary>

        public BigInt()
        {
            this.size = 0;
            this.sign = true;
        }

        public BigInt(StringBuilder s)
        {
            this.size = s.Length;
            this.number = new int[this.size];
            int m = s.Length - 1;
            int k = m;
            for (int i = 0; i < s.Length; i++)
            {
                number[i] = s[k] - '0';
                --k;

            }
            this.sign = true;
        }
        public BigInt(string s)
        {
            string temp = "";
            //   if (s[0] == '-') this.sign = false;
            // else this.sign = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    temp += s[i];
                }
            }

            this.size = temp.Length;
            this.number = new int[this.size];
            int u = temp.Length - 1;
            for (int i = 0; i < this.size; i++)
            {
                this.number[i] = temp[u] - '0';
                u--;
            }
        }

        public BigInt(int[] arr)
        {
            this.size = arr.Length;
            this.number = new int[this.size];
            for (int i = 0; i < arr.Length; i++)
                this.number[i] = arr[i];
            this.sign = true;
        }
        public BigInt(int size, int value)
        {
        this.number = new int [size];
        this.size = size;
        this.sign = true ;
        }
        public BigInt(int number)
        {
            StringBuilder s = new StringBuilder(number.ToString());
            this.size = s.Length;
            this.number = new int[this.size];
            int m = s.Length - 1;
            int k = m;
            for (int i = 0; i < s.Length; i++)
            {
                this.number[i] = s[k] - '0';
                --k;

            }
            this.sign = true;
        }

        public BigInt(BigInt number)
        {
            this.size = number.size;
            this.sign = number.sign;
            Array.Copy(number.number, 0, this.number, 0, number.number.Length);
        }

        #endregion

        #region Tools

        /// <param name="i"></param>
        /// <returns>Returns index "i" in a BigInt</returns>
        public int index(int i)
        {
            return this.number[i];
        }
        
        public void set(int i ,int x)
        {
            this.number[i] = x;
        }

        public static bool equals(BigInt number1, BigInt number2)
        {
            if (number1.size != number2.size)
                return false;
            else 
            {
                for (int k = 0; k < number1.size; k++)
                {
                    if (number1.number[k] != number2.number[k])
                        return false;
                    else if (number1.number[k] == number2.number[k])
                        continue;
                   
                }
                return true;
            } 

        }
        public static bool Prime(BigInt number)
        {
            BigInt random = new BigInt(2);
            BigInt tmp =random ^ (number-new BigInt(1));
            BigInt tmp2 = tmp % number;
            BigInt x = new BigInt(1);
            if (BigInt.equals(tmp2,x))
                return true;
            else
                return false;
           // return true;
        }
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>"true" if number1 > number2 & "false" otherwise</returns>
        public static bool operator >(BigInt number1, BigInt number2)
        {
            int mostLength = (number1.size > number2.size) ? number1.size : number2.size;
            BigInt new_number1, new_number2;
            if (number1.size != number2.size)
            {
                int[] Atemp = new int[mostLength];
                Array.Copy(number1.number, 0, Atemp, 0, number1.size);
                new_number1 = new BigInt(Atemp);
                int[] Btemp = new int[mostLength];
                Array.Copy(number2.number, 0, Btemp, 0, number2.size);
                new_number2 = new BigInt(Btemp);
            }
            else
            {
                new_number1 = number1;
                new_number2 = number2;
            }

            for (int i = mostLength - 1; i >= 0; i--)
            {
                if (new_number1.index(i) > new_number2.index(i))
                    return true;
                else if (number1.index(i) < number2.index(i))
                    return false;
                else
                    continue;
            }
            return false;
        }

        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>"true" if number1 < number2 & "false" otherwise</returns>
        public static bool operator <(BigInt number1, BigInt number2)
        {

            int mostLength = (number1.size > number2.size) ? number1.size : number2.size;
            BigInt new_number1, new_number2;

            if (mostLength != number1.size)
            {
                int[] Atemp = new int[mostLength];

                Array.Copy(number1.number, 0, Atemp, 0, number1.size);
                new_number1 = new BigInt(Atemp);
            }
            else
                new_number1 = number1;

            if (mostLength != number2.size)
            {
                int[] Btemp = new int[mostLength];
                Array.Copy(number2.number, 0, Btemp, 0, number2.size);
                new_number2 = new BigInt(Btemp);
            }
            else
                new_number2 = number2;




            for (int i = mostLength - 1; i >= 0; i--)
            {
                if (new_number1.number[i] < new_number2.number[i])
                    return true;
                else if (new_number1.number[i] > new_number2.number[i])
                    return false;
                else
                    continue;
            }
            return false;
        }

        /// <param name="number">Prints the BigInt</param>
        /// 

        public BigInt append(BigInt number)
        {
            int tmpsize = this.size + number.size;
            int[] tmp = new int[tmpsize];
            int c=0;
            for (int i = 0; i < tmpsize; i++)
            {
                if (i <number.size)
                     tmp[i] = number.number[i];
                   
                else
                {
                    tmp[i] = this.number[c];
                    c++;
                }
                
            }
            BigInt res = new BigInt(tmp);
            return res;
        
        }

        public static String UIRes(BigInt number)
        {
            String res = "";
            int[] arr = new int[number.size];
            Array.Copy(number.number, arr, number.size);
            Array.Reverse(arr);
            bool zero = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0 || !zero)
                {
                    res += arr[i];
                    zero = false;
                }
            }

            return res;
        }


        public static void res(BigInt number)
        {
            Array.Reverse(number.number);
            if (number.sign == false)
                Console.Write('-');
            bool zero = true;
            for (int i = 0; i < number.size; i++)
            {
                if (number.number[i] != 0 || !zero)
                {
                    Console.Write(number.index(i));
                    zero = false;
                }
            }

            if (zero)
                Console.Write(0);
            //for (int i = 0; i < number.size; i++)
            //    Console.Write(number.index(i));
            Console.Write("\n");
        }

        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns the modulus</returns>
        public static BigInt operator %(BigInt number1, BigInt number2)
        {
            BigInt[] result;
            result = number1 / number2;
            int[] tmp = remove(result[1].number);
            return new BigInt(tmp);
        }
        public static int[] remove(int[] res)
        {
            // bool zero=true;
            int count = 0;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                if (res[i] != 0)
                {
                    //zero = false;
                    break;
                }
                else
                    count++;
            }
            int[] new_res = new int[res.Length - count];
            for (int i = 0; i < res.Length - count; i++)
                new_res[i] = res[i];
            return new_res;
        }

        #endregion

        #region EvenOrOdd

        /// <param name="number"></param>
        /// <returns>"true" for even & "false" for odd</returns>

        public static bool Even(BigInt number)
        {
            if (number.number[0] % 2 == 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Add

        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Sum of the two numbers</returns>

        private static int[] Add(int[] A, int[] B)
        {
            int N = Math.Max(A.Length, B.Length);
            if (A.Length < N)
            {
                int[] Atemp = new int[N];
                Array.Copy(A, 0, Atemp, 0, A.Length);
                A = Atemp;
            }
            else if (B.Length < N)
            {
                int[] Btemp = new int[N];
                Array.Copy(B, 0, Btemp, 0, B.Length);
                B = Btemp;
            }

            int[] res = new int[N];
            int result = 0, carry = 0;
            for (int i = 0; i < N; i++)
            {
                result = A[i] + B[i] + carry;
                carry = 0;
                if (result > 9)
                {
                    res[i] = result % 10;
                    carry = result / 10;
                }
                else
                {
                    res[i] = result;
                }
            }

            if (carry != 0)
            {
                int[] newres = new int[N + 1];
                Array.Copy(res, 0, newres, 0, N);
                newres[N] = carry;
                res = newres;
            }
            //int[] new_res = remove(res);

            //return new_res;
            return res;
        }


        public static BigInt operator +(BigInt number1, BigInt number2)
        {

            int[] res = Add(number1.number, number2.number);
            return new BigInt(res);
        }

        #endregion

        #region Subtract

        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>The subtraction of A - B</returns>
        private static int[] Subtract(int[] A, int[] B)
        {
            int N = Math.Max(A.Length, B.Length);
            if (A.Length < N)
            {
                int[] Atemp = new int[N];
                Array.Copy(A, 0, Atemp, 0, A.Length);
                A = Atemp;
            }
            else if (B.Length < N)
            {
                int[] Btemp = new int[N];
                Array.Copy(B, 0, Btemp, 0, B.Length);
                B = Btemp;
            }

            int[] res = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (A[i] < B[i])
                {
                    A[i] += 10;
                    A[i + 1] = A[i + 1] - 1;
                }

                res[i] = A[i] - B[i];
            }
            //int[] new_res = remove(res);
            //return new_res;
            return res;
        }

        public static BigInt operator -(BigInt number1, BigInt number2)
        {
            int[] res;
            BigInt result;
            if (number1 < number2)
            {
                res = Subtract(number2.number, number1.number);
                result = new BigInt(res);
                result.sign = false;
            }
            else
            {
                res = Subtract(number1.number, number2.number);
                result = new BigInt(res);
            }


            return result;
        }

        #endregion

        #region Divide

        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>The divison of number1 / number2</returns>

        public static BigInt[] operator /(BigInt number1, BigInt number2)
        {
            int mostLength = (number1.size > number2.size) ? number1.size : number2.size;
            BigInt new_number1, new_number2;

            if (mostLength > number1.size)
            {
                int[] number1temp = new int[mostLength];
                Array.Copy(number1.number, 0, number1temp, 0, number1.size);
                new_number1 = new BigInt(number1temp);
                new_number2 = number2;

            }
            else if (mostLength > number2.size)
            {
                int[] number2temp = new int[mostLength];
                Array.Copy(number2.number, 0, number2temp, 0, number2.size);
                new_number2 = new BigInt(number2temp);
                new_number1 = number1;
            }
            else
            {
                new_number1 = new BigInt(number1.number);
                new_number2 = new BigInt(number2.number);
            }

            BigInt[] res = new BigInt[2];
            if (new_number1 < new_number2)
            {
                res[0] = new BigInt(0);
                res[1] = new_number1;
                return res;
            }
            res = new_number1 / (new_number2 + new_number2);
            res[0] = (res[0] + res[0]);

            if ((res[1] < new_number2))
            {
                return res;
            }

            else
            {
                BigInt one = new BigInt(1);
                res[0] = res[0] + one;

                res[1] = res[1] - new_number2; //r - b
                return res;
            }
        }

        #endregion


        //Comming Task

        #region Multiply

        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>The Multiplication of A * B BigInts</returns>
        private static int[] Multiply(int[] A, int[] B)
        {
            int N = Math.Max(A.Length, B.Length);
            if (A.Length != B.Length || (N % 2 != 0 && N != 1))
            {
                int[] Atemp;
                if (N % 2 != 0) { Atemp = new int[N + 1]; }
                else { Atemp = new int[N]; }
                Array.Copy(A, 0, Atemp, 0, A.Length);
                A = Atemp;
                int[] Btemp;
                if (N % 2 != 0) { Btemp = new int[N + 1]; }
                else { Btemp = new int[N]; }
                Array.Copy(B, 0, Btemp, 0, B.Length);
                B = Btemp;
                N = A.Length;
            }

            int[] res;
            if (N == 1)
            {
                int result = A[0] * B[0];
                if (result > 9)
                {
                    res = new int[2 * N];
                    res[0] = result % 10;
                    res[1] = result / 10;
                }
                else
                {
                    res = new int[N];
                    res[0] = result;
                }
                return res;
            }

            int NN = N / 2;
            int[] Aright = new int[NN];
            Array.Copy(A, 0, Aright, 0, NN);
            int[] Aleft = new int[NN];
            Array.Copy(A, NN, Aleft, 0, NN);
            int[] Bright = new int[NN];
            Array.Copy(B, 0, Bright, 0, NN);
            int[] Bleft = new int[NN];
            Array.Copy(B, NN, Bleft, 0, NN);

            int[] first_term = Multiply(Aleft, Bleft);
            int[] second_term = Multiply(Aright, Bright);
            int[] third_term = Subtract(Subtract(Multiply(Add(Aleft, Aright), Add(Bleft, Bright)), first_term), second_term);

            int[] temp_first = new int[N + first_term.Length];
            Array.Copy(first_term, 0, temp_first, N, first_term.Length);
            first_term = temp_first;
            int[] temp_third = new int[NN + third_term.Length];
            Array.Copy(third_term, 0, temp_third, NN, third_term.Length);
            third_term = temp_third;

            res = Add(Add(first_term, second_term), third_term);


            return res;
        }

        public static BigInt operator *(BigInt number1, BigInt number2)
        {
            int[] res = Multiply(number1.number, number2.number);
            int[] new_res = remove(res);
            return new BigInt(new_res);
        }

        #endregion


        #region Encryption_Decrytion

        public static BigInt En_Decrytion(BigInt ED, BigInt N, BigInt M)
        {
            BigInt result;
            result = ModExp(M, ED, N);
            return result;
        }

        #endregion

        #region Power

        public static BigInt power(BigInt A, BigInt N)
        {
            bool zero = true;
            for (int i = 0; i < N.number.Length; i++)
            {
                if (N.number[i] != 0)
                {
                    zero = false;
                    break;
                }
            }
            if (zero && N.number[0] == 0)
                return new BigInt(1);
            else if (zero && N.number[0] == 1)
                return A;
            BigInt[] pover_two;
            BigInt two = new BigInt(2);
            pover_two = N / two;
            BigInt res = power(A, pover_two[0]);
            if (!Even(N))
            {
                return res * res * A;
            }
            else
                return res * res;
        }


        public static BigInt operator ^(BigInt A, BigInt K)
        {
            BigInt res = power(A, K);
            return res;

        }
        //////////////////////////////////////////////////////////////////////////////////
        public static BigInt ModExp(BigInt B, BigInt P, BigInt M)
        {
            bool zero = true;
            for (int i = 1; i < P.number.Length; i++)
            {
                if (P.number[i] != 0)
                {
                    zero = false;
                    break;
                }
            }

            if (zero && P.number[0] == 0)
                return new BigInt(1);
            else if (zero && P.number[0] == 1)
                return B % M;

            BigInt[] Pover_two;
            BigInt two = new BigInt(2);
            Pover_two = P / two;
            BigInt res = ModExp(B, Pover_two[0], M);
            if (!Even(P)) //if odd
            {
                // P.number[0]--;
                res = res * res;
                res = res * B;
                return res % M;
                // return (res * res * B) % M;
            }
            else
            {
                res = res * res;
                return res % M;
                //  return (res * res) % M;
            }
        }

        #endregion

    }
}