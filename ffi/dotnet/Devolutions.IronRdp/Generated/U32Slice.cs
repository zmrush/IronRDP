// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp;

#nullable enable

public partial class U32Slice: IDisposable
{
    private unsafe Raw.U32Slice* _inner;

    public nuint Size
    {
        get
        {
            return GetSize();
        }
    }

    /// <summary>
    /// Creates a managed <c>U32Slice</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe U32Slice(Raw.U32Slice* handle)
    {
        _inner = handle;
    }

    public nuint GetSize()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("U32Slice");
            }
            nuint retVal = Raw.U32Slice.GetSize(_inner);
            return retVal;
        }
    }

    /// <exception cref="IronRdpException"></exception>
    public void Fill(uint[] buffer)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("U32Slice");
            }
            nuint bufferLength = (nuint)buffer.Length;
            fixed (uint* bufferPtr = buffer)
            {
                Raw.UtilsFfiResultVoidBoxIronRdpError result = Raw.U32Slice.Fill(_inner, bufferPtr, bufferLength);
                if (!result.isOk)
                {
                    throw new IronRdpException(new IronRdpError(result.Err));
                }
            }
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.U32Slice* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.U32Slice.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~U32Slice()
    {
        Dispose();
    }
}
