using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Generic_Types
{
    #region Point example
    class Point<T> 
    {
        public T X { get; set; }
        public T Y { get; set; }

        public override string ToString()
        {
            return String.Format("Point(x: {0}, y: {1}) ", X, Y); 
        }
    }
    #endregion
    #region Map Example
    class Map<T1, T2>
    {
        List<MapObject<T1,T2>> values = new List<MapObject<T1, T2>>();
        public Map()
        {
            
        }
        public void Add(T1 key, T2 value)
        {
            foreach(MapObject<T1,T2> mObject in this.values)
            {
                if(mObject.Key.Equals(key))
                {
                    mObject.Value = value;
                    return;
                }
            }
            this.values.Add(new MapObject<T1, T2>(key, value));
        }
        public T2 GetValue(T1 key)
        {
            foreach (MapObject<T1, T2> mObject in this.values)
            {
                if (mObject.Key.Equals(key))
                { 
                    return mObject.Value;
                }
            }
            return default(T2); 
        }

    }
    class MapObject<T1, T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }
        public MapObject(T1 key, T2 value)
        {
            this.Key = key;
            this.Value = value;
        }
        
    }
    #endregion
    #region Static Functions Example
    static class FunctionsExample
    {
        public static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
    #endregion  


}
