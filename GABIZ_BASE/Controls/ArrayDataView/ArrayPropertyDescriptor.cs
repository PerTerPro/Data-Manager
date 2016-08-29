// GABIZ.Base Control Library
// The GABIZ.Base.NET Framework
// http://GABIZ.Base-net.origo.ethz.ch
//
// Copyright � C�sar Souza, 2009-2011
// cesarsouza at gmail.com
// http://www.crsouza.com
//
// Copyright � Mihail Stefanov, 2004
// Adapted from original code from Mihail Stefanov <http://www.mommosoft.com>
// Available in: http://www.codeproject.com/KB/database/BindArrayGrid.aspx
//

namespace GABIZ.Base.Controls
{

    using System;
    using System.Diagnostics;
    using System.ComponentModel;

    /// <summary>
    ///   Provides an abstraction of array values.
    /// </summary>
    public class ArrayPropertyDescriptor : PropertyDescriptor
    {
        private string name;
        private Type type;
        private int columnIndex;

        /// <summary>
        ///   Constructs a new Array Property Descriptor.
        /// </summary>
        /// <param name="name">A title for the array.</param>
        /// <param name="type">The type of the property being displayed.</param>
        /// <param name="index">The index to display.</param>
        public ArrayPropertyDescriptor(string name, Type type, int index)
            : base(name, null)
        {
            this.name = name;
            this.type = type;
            this.columnIndex = index;
        }

        /// <summary>
        ///   Returns the name of the array.
        /// </summary>
        public override string DisplayName
        {
            get { return name; }
        }

        /// <summary>
        ///   Returns the type of ArrayRowView.
        /// </summary>
        public override Type ComponentType
        {
            get { return typeof(ArrayRowView); }
        }

        /// <summary>
        ///   Returns false.
        /// </summary>
        public override bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        ///   Gets the type of the underlying multidimensional array.
        /// </summary>
        public override Type PropertyType
        {
            get { return type; }
        }

        /// <summary>
        ///   Gets a value from the array.
        /// </summary>
        public override object GetValue(object component)
        {
            try
            {
                return ((ArrayRowView)component).GetColumn(columnIndex);
            }
            catch (ArgumentException e)
            {
                Debug.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Debug.WriteLine(e);
            }

            return null;
        }

        /// <summary>
        ///   Sets a value to the array.
        /// </summary>
        public override void SetValue(object component, object value)
        {
            ArrayRowView rowView = component as ArrayRowView;

            if (rowView != null)
                rowView.SetColumnValue(columnIndex, value);
        }

        /// <summary>
        ///   Returns false.
        /// </summary>
        public override bool CanResetValue(object component)
        {
            return false;
        }

        /// <summary>
        ///   Does nothing.
        /// </summary>
        public override void ResetValue(object component)
        {
        }

        /// <summary>
        ///   Returns false.
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
