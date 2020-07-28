using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    /// <summary>
    /// 排序
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="source">需要排序的list<int></param>
        public static void BubbleSort(this List<int> list)
        {

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="list">需要排序的list<int></param>
        public static void SelectionSort(this List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[minIndex] > list[j])
                    {
                        minIndex = j;
                    }
                }
                var temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }
        }


        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="list"></param>
        public static void InsertionSort(this List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1])
                {
                    var temp = list[i];
                    var j = i;
                    while (j > 0 && temp < list[j - 1])
                    {
                        list[j] = list[j - 1];
                        j--;
                    }
                    list[j] = temp;
                }
            }
        }

        public static void ShellSort(this List<int> list)
        {
            var lenth = Math.Floor((double)list.Count / 2);
            for (var gap = (int)lenth; gap > 0; gap = (int)lenth)
            {
                for (var i = gap; i < lenth; i++)
                {
                    var j = i;
                    var current = list[i];
                    while (j - gap >= 0 && current < list[j - gap])
                    {
                        list[j] = list[j - gap];
                        j = j - gap;
                    }
                    list[j] = current;
                }
            }
        }

    }
}
