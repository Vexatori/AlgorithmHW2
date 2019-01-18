//Суюнов Александр

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW2
{
    class Program
    {
        static void Main( string[] args )
        {
            //ArrowMotionSolution( 0 );
            //Console.WriteLine( InBinary( 15 ) );
            Console.ReadLine();
        }

        /// <summary>
        /// Решение для первой задачи на движение стрелки
        /// </summary>
        /// <param name="k"></param>
        public static void ArrowMotionSolution( int k )
        {
            if( k != 13 )
            {
                if( k < 8 )
                {
                    Console.WriteLine( "Вперед" );
                }
                if( k >= 8 && k < 13 )
                {
                    Console.Write( $"Поворот налево\nВперед\nПоворот направо\nВперед\n" );
                }
                ArrowMotionSolution( k + 1 );
            }
        }

        /// <summary>
        /// Решение для первой задачи из ДЗ
        /// </summary>
        /// <param name="number">Число, которое нужно перевести в двоичную систему</param>
        /// <returns></returns>
        public static string InBinary( int number )
        {
            string strNumber = "";
            if( number != 0 )
            {
                strNumber = ( number % 2 ).ToString() + InBinary( number / 2 );
            }
            return new string( strNumber.Reverse().ToArray() );
        }
    }
}
