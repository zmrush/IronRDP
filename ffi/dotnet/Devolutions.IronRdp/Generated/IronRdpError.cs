// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp;

#nullable enable

/// <summary>
/// Stringified Picky error along with an error kind.
/// </summary>
public partial class IronRdpError: IDisposable
{
    private unsafe Raw.IronRdpError* _inner;

    public IronRdpErrorKind Kind
    {
        get
        {
            return GetKind();
        }
    }

    /// <summary>
    /// Creates a managed <c>IronRdpError</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe IronRdpError(Raw.IronRdpError* handle)
    {
        _inner = handle;
    }

    /// <summary>
    /// Returns the error as a string.
    /// </summary>
    public void ToDisplay(DiplomatWriteable writeable)
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("IronRdpError");
            }
            Raw.IronRdpError.ToDisplay(_inner, &writeable);
        }
    }

    /// <summary>
    /// Returns the error as a string.
    /// </summary>
    public string ToDisplay()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("IronRdpError");
            }
            DiplomatWriteable writeable = new DiplomatWriteable();
            Raw.IronRdpError.ToDisplay(_inner, &writeable);
            string retVal = writeable.ToUnicode();
            writeable.Dispose();
            return retVal;
        }
    }

    /// <summary>
    /// Returns the error kind.
    /// </summary>
    /// <returns>
    /// A <c>IronRdpErrorKind</c> allocated on C# side.
    /// </returns>
    public IronRdpErrorKind GetKind()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("IronRdpError");
            }
            Raw.IronRdpErrorKind retVal = Raw.IronRdpError.GetKind(_inner);
            return (IronRdpErrorKind)retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.IronRdpError* AsFFI()
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

            Raw.IronRdpError.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~IronRdpError()
    {
        Dispose();
    }
}
