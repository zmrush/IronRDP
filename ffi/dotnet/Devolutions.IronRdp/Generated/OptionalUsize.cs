// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp;

#nullable enable

public partial class OptionalUsize: IDisposable
{
    private unsafe Raw.OptionalUsize* _inner;

    /// <summary>
    /// Creates a managed <c>OptionalUsize</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe OptionalUsize(Raw.OptionalUsize* handle)
    {
        _inner = handle;
    }

    public bool IsSome()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("OptionalUsize");
            }
            bool retVal = Raw.OptionalUsize.IsSome(_inner);
            return retVal;
        }
    }

    /// <exception cref="IronRdpException"></exception>
    public nuint Get()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("OptionalUsize");
            }
            Raw.UtilsFfiResultUsizeBoxIronRdpError result = Raw.OptionalUsize.Get(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            nuint retVal = result.Ok;
            return retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.OptionalUsize* AsFFI()
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

            Raw.OptionalUsize.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~OptionalUsize()
    {
        Dispose();
    }
}
