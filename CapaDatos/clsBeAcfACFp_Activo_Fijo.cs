public class clsBeAcfACFp_Activo_Fijo : ICloneable {

	private int mACFid = 0;
	private string mBUKRS = '';
	private string mSEGMENT = '';
	private string mANLKL = '';
	private string mPERNR = '';
	private string mCSTid = '';
	private string mMVMid = '';
	private Date mACFfmovimiento = Date.Now();
	private string mVNRid = '';
	private string mACFdescripcion = '';
	private Date mACFfincorporacion = Date.Now();
	private Date mACFfcapitalizacion = Date.Now();
	private int mACFvutiltribanio = 0;
	private int mACFvutiltribdia = 0;
	private double mACFvalortrib = 0.0;
	private int mACFvutilniifanio = 0;
	private int mACFvutilniifdia = 0;
	private double mACFvalorniif = 0.0;
	private string mACFdepacutrib = '';
	private double mACFdepacuniif = 0.0;
	private string mACFobra = '';
	private string mACFord41 = '';
	private string mACFord42 = '';
	private string mACFord43 = '';
	private string mACFord44 = '';
	private string mACFanlue = '';
	private double mACFfactortrib = 0.0;
	private double mACFfactorniif = 0.0;
	private string mACFcuenta = '';
	private string mACFcuentadep = '';
	private string mCMPid = '';
	private string mACFobservacion = '';
	private string mLIFNR = '';
	private string mACFnotaingreso = '';
	private string mACFfechanotaingreso = '';
	private string mACFordencompra = '';
	private Date mACFfechaordencompra = Date.Now();
	private string mBLART = '';
	private string mACFcomprobante = '';
	private string mKOSTL = '';
	private int mAMBid = 0;
	private int mUBEid = 0;
	private Date mACFfechacomprobante = Date.Now();
	private string mV_T087U_ANLUE = '';

	public Integer ACFid {
		get {
			return mACFid;
		}
		set {
			mACFid = value;
		}
	}

	public String BUKRS {
		get {
			return mBUKRS;
		}
		set {
			mBUKRS = value;
		}
	}

	public String SEGMENT {
		get {
			return mSEGMENT;
		}
		set {
			mSEGMENT = value;
		}
	}

	public String ANLKL {
		get {
			return mANLKL;
		}
		set {
			mANLKL = value;
		}
	}

	public String PERNR {
		get {
			return mPERNR;
		}
		set {
			mPERNR = value;
		}
	}

	public String CSTid {
		get {
			return mCSTid;
		}
		set {
			mCSTid = value;
		}
	}

	public String MVMid {
		get {
			return mMVMid;
		}
		set {
			mMVMid = value;
		}
	}

	public Date ACFfmovimiento {
		get {
			return mACFfmovimiento;
		}
		set {
			mACFfmovimiento = value;
		}
	}

	public String VNRid {
		get {
			return mVNRid;
		}
		set {
			mVNRid = value;
		}
	}

	public String ACFdescripcion {
		get {
			return mACFdescripcion;
		}
		set {
			mACFdescripcion = value;
		}
	}

	public Date ACFfincorporacion {
		get {
			return mACFfincorporacion;
		}
		set {
			mACFfincorporacion = value;
		}
	}

	public Date ACFfcapitalizacion {
		get {
			return mACFfcapitalizacion;
		}
		set {
			mACFfcapitalizacion = value;
		}
	}

	public Integer ACFvutiltribanio {
		get {
			return mACFvutiltribanio;
		}
		set {
			mACFvutiltribanio = value;
		}
	}

	public Integer ACFvutiltribdia {
		get {
			return mACFvutiltribdia;
		}
		set {
			mACFvutiltribdia = value;
		}
	}

	public Double ACFvalortrib {
		get {
			return mACFvalortrib;
		}
		set {
			mACFvalortrib = value;
		}
	}

	public Integer ACFvutilniifanio {
		get {
			return mACFvutilniifanio;
		}
		set {
			mACFvutilniifanio = value;
		}
	}

	public Integer ACFvutilniifdia {
		get {
			return mACFvutilniifdia;
		}
		set {
			mACFvutilniifdia = value;
		}
	}

	public Double ACFvalorniif {
		get {
			return mACFvalorniif;
		}
		set {
			mACFvalorniif = value;
		}
	}

	public String ACFdepacutrib {
		get {
			return mACFdepacutrib;
		}
		set {
			mACFdepacutrib = value;
		}
	}

	public Double ACFdepacuniif {
		get {
			return mACFdepacuniif;
		}
		set {
			mACFdepacuniif = value;
		}
	}

	public String ACFobra {
		get {
			return mACFobra;
		}
		set {
			mACFobra = value;
		}
	}

	public String ACFord41 {
		get {
			return mACFord41;
		}
		set {
			mACFord41 = value;
		}
	}

	public String ACFord42 {
		get {
			return mACFord42;
		}
		set {
			mACFord42 = value;
		}
	}

	public String ACFord43 {
		get {
			return mACFord43;
		}
		set {
			mACFord43 = value;
		}
	}

	public String ACFord44 {
		get {
			return mACFord44;
		}
		set {
			mACFord44 = value;
		}
	}

	public String ACFanlue {
		get {
			return mACFanlue;
		}
		set {
			mACFanlue = value;
		}
	}

	public Double ACFfactortrib {
		get {
			return mACFfactortrib;
		}
		set {
			mACFfactortrib = value;
		}
	}

	public Double ACFfactorniif {
		get {
			return mACFfactorniif;
		}
		set {
			mACFfactorniif = value;
		}
	}

	public String ACFcuenta {
		get {
			return mACFcuenta;
		}
		set {
			mACFcuenta = value;
		}
	}

	public String ACFcuentadep {
		get {
			return mACFcuentadep;
		}
		set {
			mACFcuentadep = value;
		}
	}

	public String CMPid {
		get {
			return mCMPid;
		}
		set {
			mCMPid = value;
		}
	}

	public String ACFobservacion {
		get {
			return mACFobservacion;
		}
		set {
			mACFobservacion = value;
		}
	}

	public String LIFNR {
		get {
			return mLIFNR;
		}
		set {
			mLIFNR = value;
		}
	}

	public String ACFnotaingreso {
		get {
			return mACFnotaingreso;
		}
		set {
			mACFnotaingreso = value;
		}
	}

	public String ACFfechanotaingreso {
		get {
			return mACFfechanotaingreso;
		}
		set {
			mACFfechanotaingreso = value;
		}
	}

	public String ACFordencompra {
		get {
			return mACFordencompra;
		}
		set {
			mACFordencompra = value;
		}
	}

	public Date ACFfechaordencompra {
		get {
			return mACFfechaordencompra;
		}
		set {
			mACFfechaordencompra = value;
		}
	}

	public String BLART {
		get {
			return mBLART;
		}
		set {
			mBLART = value;
		}
	}

	public String ACFcomprobante {
		get {
			return mACFcomprobante;
		}
		set {
			mACFcomprobante = value;
		}
	}

	public String KOSTL {
		get {
			return mKOSTL;
		}
		set {
			mKOSTL = value;
		}
	}

	public Integer AMBid {
		get {
			return mAMBid;
		}
		set {
			mAMBid = value;
		}
	}

	public Integer UBEid {
		get {
			return mUBEid;
		}
		set {
			mUBEid = value;
		}
	}

	public Date ACFfechacomprobante {
		get {
			return mACFfechacomprobante;
		}
		set {
			mACFfechacomprobante = value;
		}
	}

	public String V_T087U_ANLUE {
		get {
			return mV_T087U_ANLUE;
		}
		set {
			mV_T087U_ANLUE = value;
		}
	}

	AcfACFp_Activo_Fijo(){
	}

	AcfACFp_Activo_Fijo(){ref int ACFid, string BUKRS, string SEGMENT, string ANLKL, string PERNR, string CSTid, string MVMid, Date ACFfmovimiento, string VNRid, string ACFdescripcion, Date ACFfincorporacion, Date ACFfcapitalizacion, int ACFvutiltribanio, int ACFvutiltribdia, double ACFvalortrib, int ACFvutilniifanio, int ACFvutilniifdia, double ACFvalorniif, string ACFdepacutrib, double ACFdepacuniif, string ACFobra, string ACFord41, string ACFord42, string ACFord43, string ACFord44, string ACFanlue, double ACFfactortrib, double ACFfactorniif, string ACFcuenta, string ACFcuentadep, string CMPid, string ACFobservacion, string LIFNR, string ACFnotaingreso, string ACFfechanotaingreso, string ACFordencompra, Date ACFfechaordencompra, string BLART, string ACFcomprobante, string KOSTL, int AMBid, int UBEid, Date ACFfechacomprobante, string V_T087U_ANLUE)
		mACFid = ACFid;
		mBUKRS = BUKRS;
		mSEGMENT = SEGMENT;
		mANLKL = ANLKL;
		mPERNR = PERNR;
		mCSTid = CSTid;
		mMVMid = MVMid;
		mACFfmovimiento = ACFfmovimiento;
		mVNRid = VNRid;
		mACFdescripcion = ACFdescripcion;
		mACFfincorporacion = ACFfincorporacion;
		mACFfcapitalizacion = ACFfcapitalizacion;
		mACFvutiltribanio = ACFvutiltribanio;
		mACFvutiltribdia = ACFvutiltribdia;
		mACFvalortrib = ACFvalortrib;
		mACFvutilniifanio = ACFvutilniifanio;
		mACFvutilniifdia = ACFvutilniifdia;
		mACFvalorniif = ACFvalorniif;
		mACFdepacutrib = ACFdepacutrib;
		mACFdepacuniif = ACFdepacuniif;
		mACFobra = ACFobra;
		mACFord41 = ACFord41;
		mACFord42 = ACFord42;
		mACFord43 = ACFord43;
		mACFord44 = ACFord44;
		mACFanlue = ACFanlue;
		mACFfactortrib = ACFfactortrib;
		mACFfactorniif = ACFfactorniif;
		mACFcuenta = ACFcuenta;
		mACFcuentadep = ACFcuentadep;
		mCMPid = CMPid;
		mACFobservacion = ACFobservacion;
		mLIFNR = LIFNR;
		mACFnotaingreso = ACFnotaingreso;
		mACFfechanotaingreso = ACFfechanotaingreso;
		mACFordencompra = ACFordencompra;
		mACFfechaordencompra = ACFfechaordencompra;
		mBLART = BLART;
		mACFcomprobante = ACFcomprobante;
		mKOSTL = KOSTL;
		mAMBid = AMBid;
		mUBEid = UBEid;
		mACFfechacomprobante = ACFfechacomprobante;
		mV_T087U_ANLUE = V_T087U_ANLUE;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
