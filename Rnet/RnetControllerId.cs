﻿using System;

namespace Rnet
{

    /// <summary>
    /// Specifies an RNET ControllerID component of a <see cref="RnetDeviceId"/>.
    /// </summary>
    public struct RnetControllerId : IComparable<RnetControllerId>, IComparable
    {

        public static readonly RnetControllerId AllDevices = 0x7f;

        /// <summary>
        /// Implicitly converts a <see cref="RnetControllerId"/> to a <see cref="Byte"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static implicit operator byte(RnetControllerId id)
        {
            return id.Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="Byte"/> to a <see cref="RnetControllerId"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static implicit operator RnetControllerId(byte value)
        {
            return new RnetControllerId(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Int32"/> to a <see cref="RnetControllerId"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static implicit operator RnetControllerId(int value)
        {
            return new RnetControllerId((byte)value);
        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="value"></param>
        public RnetControllerId(byte value)
            : this()
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the underlying value of the controller ID.
        /// </summary>
        public byte Value { get; set; }

        /// <summary>
        /// Indicates whether this instance and the specified object are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is RnetControllerId ? ((RnetControllerId)obj).Value == Value : false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            if (this == AllDevices)
                return string.Format("{0} /* AllDevices */", Value);

            return Value.ToString();
        }

        /// <summary>
        /// Compares this <see cref="RnetControllerId"/> to another <see cref="RnetControllerId"/>.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int IComparable<RnetControllerId>.CompareTo(RnetControllerId other)
        {
            return Value.CompareTo(other.Value);
        }

        /// <summary>
        /// Compares the current object with another object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int IComparable.CompareTo(object obj)
        {
            return ((IComparable<RnetControllerId>)this).CompareTo((RnetControllerId)obj);
        }

    }

}