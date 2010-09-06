/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class readargs : XdrAble {
    public nfshandle file;
    public int offset;
    public int count;
    public int totalcount;

    public readargs() {
    }

    public readargs(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        file.xdrEncode(xdr);
        xdr.xdrEncodeInt(offset);
        xdr.xdrEncodeInt(count);
        xdr.xdrEncodeInt(totalcount);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        file = new nfshandle(xdr);
        offset = xdr.xdrDecodeInt();
        count = xdr.xdrDecodeInt();
        totalcount = xdr.xdrDecodeInt();
    }

}
// End of readargs.cs