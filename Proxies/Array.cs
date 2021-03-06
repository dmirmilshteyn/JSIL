﻿using System;
using JSIL.Meta;
using JSIL.Proxy;

namespace JSIL.Proxies {
    using System.Collections;
    using System.Collections.Generic;

    [JSProxy(
        typeof(Array),
        memberPolicy: JSProxyMemberPolicy.ReplaceDeclared
    )]
    public abstract class ArrayProxy {
        [JSChangeName("length")]
        [JSAlwaysAccessAsProperty]
        [JSNeverReplace]
        [JSIsPure]
        abstract public int Length { get; }

        [JSChangeName("length")]
        [JSAlwaysAccessAsProperty]
        [JSNeverReplace]
        [JSIsPure]
        abstract public long LongLength { get; } 


        [JSReplacement("JSIL.Array.New($elementType, $size)")]
        public static System.Array CreateInstance (Type elementType, Int32 size) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New.apply(null, [$elementType].concat($sizes))")]
        public static System.Array CreateInstance (Type elementType, AnyType[] sizes) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New($elementType, $sizeX, $sizeY)")]
        public static System.Array CreateInstance (Type elementType, AnyType sizeX, AnyType sizeY) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.MultidimensionalArray.New($elementType, $sizeX, $sizeY, $sizeZ)")]
        public static System.Array CreateInstance (Type elementType, AnyType sizeX, AnyType sizeY, AnyType sizeZ) {
            throw new InvalidOperationException();
        }

        [JSExternal]
        [JSRuntimeDispatch]
        public abstract void Set (params AnyType[] values);

        [JSExternal]
        [JSRuntimeDispatch]
        public abstract AnyType Get (params AnyType[] values);

        [JSReplacement("$this.Get.apply($this, $indices)")]
        public abstract AnyType GetValue (AnyType[] indices);

        [JSReplacement("$this.Set.apply($this, $indices.concat([$value]))")]
        public abstract void SetValue (AnyType value, AnyType[] indices);

        [JSReplacement("JSIL.Array.IndexOf($array, 0, $array.length, $value)")]
        public static int IndexOf (Array array, AnyType value) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.IndexOf($array, $startIndex, $array.length - $startIndex, $value)")]
        public static int IndexOf (Array array, AnyType value, int startIndex) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.IndexOf($array, $startIndex, $count, $value)")]
        public static int IndexOf(Array array, AnyType value, int startIndex, int count)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.IndexOf($array, 0, $array.length, $value)")]
        public static int IndexOf<T> (T[] array, T value) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.IndexOf($array, $startIndex, $array.length - $startIndex, $value)")]
        public static int IndexOf<T> (T[] array, T value, int startIndex) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.IndexOf($array, $startIndex, $count, $value)")]
        public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.Clone($this)")]
        public object Clone () {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.Array.Erase($array, $etypeof(array), $index, $length)")]
        public static extern void Clear (Array array, int index, int length);

        [JSReplacement("JSIL.Array.CopyTo($this, $array, $destinationIndex)")]
        public void CopyTo (Array array, int destinationIndex) {
            throw new InvalidOperationException();
        }

        [JSReplacement("Array.prototype.sort.call($array)")]
        public static void Sort (AnyType[] array) {
            throw new InvalidOperationException();
        }

        [JSReplacement("Array.prototype.sort.call($array)")]
        public static void Sort<T> (T[] array) {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.GetEnumerator($this)")]
        [JSIsPure]
        [JSResultIsNew]
        public System.Collections.IEnumerator GetEnumerator () {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($$jsilcore.System.Object, Array.prototype.slice.call($array), 0, $array.length, $value, null)")]
        public static int BinarySearch(Array array, object value)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($$jsilcore.System.Object, Array.prototype.slice.call($array), 0, $array.length, $value, $comparer)")]
        public static int BinarySearch(Array array, object value, IComparer comparer)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($$jsilcore.System.Object, Array.prototype.slice.call($array), $startIndex, $length, $value, null)")]
        public static int BinarySearch(Array array, int startIndex, int length, object value)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($$jsilcore.System.Object, Array.prototype.slice.call($array), $startIndex, $length, $value, $comparer)")]
        public static int BinarySearch(Array array, int startIndex, int length, object value, IComparer comparer)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($typeof(value), Array.prototype.slice.call($array), 0, $array.length, $value, null)")]
        public static int BinarySearch<T>(T[] array, T value)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($typeof(value), Array.prototype.slice.call($array), 0, $array.length, $value, $comparer)")]
        public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($typeof(value), Array.prototype.slice.call($array), $startIndex, $length, $value, null)")]
        public static int BinarySearch<T>(T[] array, int startIndex, int length, T value)
        {
            throw new InvalidOperationException();
        }

        [JSReplacement("JSIL.BinarySearch($typeof(value), Array.prototype.slice.call($array), $startIndex, $length, $value, $comparer)")]
        public static int BinarySearch<T>(T[] array, int startIndex, int length, T value, IComparer<T> comparer)
        {
            throw new InvalidOperationException();
        }
    }
}
