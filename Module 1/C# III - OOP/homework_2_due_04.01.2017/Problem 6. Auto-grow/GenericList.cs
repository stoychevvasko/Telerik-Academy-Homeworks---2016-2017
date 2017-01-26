using System;
using System.Text;

namespace Problem_06
{
    /// <summary>
    /// Represents a strongly typed list of objects that can be accessed by index. 
    /// </summary>
    /// <typeparam name="T">T is <see cref="T"/></typeparam>
    public class GenericList<T>
    where T : IComparable, IComparable<T>
    {
        // fields

        /// <summary>
        /// Holds the list capacity (number of elements allowed) of a <see cref="GenericList{T}"/>.
        /// </summary>
        private int capacity;

        /// <summary>
        /// Holds the index position of the next element to be added to the current <see cref="GenericList{T}"/>.
        /// </summary>
        private int indexOfNext;

        /// <summary>
        /// Holds elements of the <see cref="T"/> type within this <see cref="GenericList{T}"/>.
        /// </summary>
        private T[] data;


        /// <summary>
        /// the list capacity (number of elements allowed) of a <see cref="GenericList{T}"/>.
        /// </summary>
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        /// <summary>
        /// Represents the index position of the next element to be added to the current <see cref="GenericList{T}"/>.
        /// </summary>
        public int IndexOfNext
        {
            get { return this.indexOfNext; }
            private set { this.indexOfNext = value; }
        }

        /// <summary>
        /// Represents the current number of elements within a <see cref="GenericList{T}"/>
        /// </summary>
        public int Count
        {
            get { return this.IndexOfNext; }
        }

        // public T[] Data
        // {
        //     get { return this.data; }
        //     private set { this.data = value; }
        // }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericList{T}"/> class.
        /// </summary>
        public GenericList()
            : this(16)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericList{T}"/> class.
        /// </summary>
        /// <param name="cap"><see cref="GenericList{T}"/> capacity to hold elements of the <see cref="T"/> type.</param>
        public GenericList(int cap)
        {
            this.Capacity = cap;
            this.IndexOfNext = 0;
            this.data = new T[cap];
        }
        /// <summary>
        /// Provides access through index position within a <see cref="GenericList{T}"/>.
        /// </summary>
        /// <param name="index">index position</param>
        /// <returns><see cref="T"/> element within a <see cref="GenericList{T}"/></returns>
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Capacity) return this.data[index];
                else throw new System.ArgumentOutOfRangeException("Cannot access outside of GenericList range!");
            }
            set
            {
                if (index >= 0 && index < this.Capacity) this.data[index] = value;
                else throw new System.ArgumentOutOfRangeException("Cannot write outside of GenericList range!");
            }
        }

        /// <summary>
        /// Adds a new <see cref="T"/> element to the <see cref="GenericList{T}"/>.
        /// </summary>
        /// <param name="element">an element of the <see cref="T"/> type</param>
        public GenericList<T> Add(T element)
        {
            if (this.IndexOfNext >= this.Capacity)
            {
                // capacity reached, list must expand
                // Auto-grow functionality from Problem 06

                this.Capacity *= 2;

                T[] tempData = new T[this.Capacity];

                this.IndexOfNext = 0;

                for (int ind = 0; ind < this.data.Length; ind++)
                {
                    tempData[indexOfNext] = this[ind];
                    indexOfNext++;
                }

                this.data = tempData;
            }

            this[IndexOfNext] = element;
            this.IndexOfNext += 1;
            return this;
        }

        /// <summary>
        /// Removes the <see cref="T"/> element at an index position from a <see cref="GenericList{T}"/>.
        /// </summary>
        /// <param name="position">index position of <see cref="T"/> element to remove</param>
        public GenericList<T> Remove(int position)
        {
            if (position >= 0 && position < this.Count)
            {
                int miniIndex = 0;
                for (int index = 0; index < IndexOfNext; index++)
                {
                    if (index != position)
                    {
                        this[miniIndex] = this[index];
                        miniIndex++;
                    }
                }
            }
            this.IndexOfNext--;
            if (this.IndexOfNext < 0) this.IndexOfNext = 0;
            return this;
        }

        // method for inserting elements

        /// <summary>
        /// Inserts a <see cref="T"/> element into a <see cref="GenericList{T}"/> at a fixed index position.
        /// </summary>
        /// <param name="element"><see cref="T"/> to be inserted</param>
        /// <param name="position">index position for insertion</param>
        public GenericList<T> Insert(T element, int position)
        {
            if (position >= 0 && position < this.IndexOfNext)
            {
                if (this.IndexOfNext == 0) return this.Add(element);
                else
                {
                    T temp = this[position];
                    this[position] = element;
                    for (int i = position + 1; i <= this.IndexOfNext; i++)
                    {
                        T tempItem = this[i];
                        this[i] = temp;
                        temp = tempItem;
                    }
                }
                this.indexOfNext++;
                return this;
            }
            else if (position >= this.IndexOfNext) return this.Add(element);
            else if (position < 0) return this.Insert(element, 0);
            else return this;
        }

        /// <summary>
        /// Finds a <see cref="T"/> element within a <see cref="GenericList{T}"/> by its value.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Index position of the <see cref="T"/> element or -1 if not found.</returns>
        public int Find(T element)
        {
            if (this.IndexOfNext == 0) return -1;
            else
            {
                for (int i = 0; i < this.IndexOfNext; i++)
                {
                    if (this[i].ToString() == element.ToString()) return i;
                }
                return -1;
            }
        }

        /// <summary>
        /// Clears a <see cref="GenericList{T}"/> of all elements.
        /// </summary>
        public void Clear()
        {
            this.data = new T[16];
            this.IndexOfNext = 0;
        }

        /// <summary>
        /// Returns a <see cref="string"/> representation of a <see cref="GenericList{T}"/> object
        /// </summary>
        /// <returns>a <see cref="string"/></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Count > 0)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    result.Append(" { ")
                          .Append(this[i])
                          .Append(" } ");
                }
            }

            if (result.Length > 0) result.Remove(result.Length - 1, 1);
            return result.ToString();
        }
    }
}
