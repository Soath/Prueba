public class clsBeAcfINBt_Inventariobienes : ICloneable {

	private int mINVid = 0;
	private int mACFid = 0;
	private string mACFactivo = '';
	private string mBUKRS = '';
	private string mSEGMENT = '';
	private string mKOSTL = '';
	private string mANLKL = '';
	private string mPERNR = '';
	private string mACTid = '';
	private string mCSTid = '';
	private string mVNRid = '';
	private Date mACFfincorporacion = Date.Now();
	private Date mACFfcapitalizacion = Date.Now();
	private int mACFvutiltribanio = 0;
	private int mACFvutiltribdia = 0;
	private double mACFvalortrib = 0.0;
	private double mACFfactortrib = 0.0;
	private double mACFdepacutrib = 0.0;
	private int mACfvutilniifanio = 0;
	private int mACFvutilniifdia = 0;
	private double mACFvalorniif = 0.0;
	private double mACFfactorniif = 0.0;
	private double mACFdepacuniif = 0.0;
	private string mACFobra = '';
	private string mACFord41 = '';
	private string mACFord42 = '';
	private string mACFord43 = '';
	private string mACFord44 = '';
	private string mACFanlue = '';
	private string mACFcuenta = '';
	private string mACFcuentadep = '';
	private string mLIFNR = '';
	private string mBLART = '';
	private string mACFcomprobante = '';
	private string mACFnotaingreso = '';
	private Date mACFfechanotaingreso = Date.Now();
	private string mACFordencompra = '';
	private string mACFobservacion = '';
	private int mAMBid = 0;
	private int mUBEid = 0;
	private Date mACFfechacomprobante = Date.Now();
	private Date mACFfechaordencompra = Date.Now();

	public Integer INVid {
		get {
			return mINVid;
		}
		set {
			mINVid = value;
		}
	}

	public Integer ACFid {
		get {
			return mACFid;
		}
		set {
			mACFid = value;
		}
	}

	public String ACFactivo {
		get {
			return mACFactivo;
		}
		set {
			mACFactivo = value;
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

	public String KOSTL {
		get {
			return mKOSTL;
		}
		set {
			mKOSTL = value;
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

	public String ACTid {
		get {
			return mACTid;
		}
		set {
			mACTid = value;
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

	public String VNRid {
		get {
			return mVNRid;
		}
		set {
			mVNRid = value;
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

	public Double ACFfactortrib {
		get {
			return mACFfactortrib;
		}
		set {
			mACFfactortrib = value;
		}
	}

	public Double ACFdepacutrib {
		get {
			return mACFdepacutrib;
		}
		set {
			mACFdepacutrib = value;
		}
	}

	public Integer ACfvutilniifanio {
		get {
			return mACfvutilniifanio;
		}
		set {
			mACfvutilniifanio = value;
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

	public Double ACFfactorniif {
		get {
			return mACFfactorniif;
		}
		set {
			mACFfactorniif = value;
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

	public String LIFNR {
		get {
			return mLIFNR;
		}
		set {
			mLIFNR = value;
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

	public String ACFnotaingreso {
		get {
			return mACFnotaingreso;
		}
		set {
			mACFnotaingreso = value;
		}
	}

	public Date ACFfechanotaingreso {
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

	public String ACFobservacion {
		get {
			return mACFobservacion;
		}
		set {
			mACFobservacion = value;
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

	public Date ACFfechaordencompra {
		get {
			return mACFfechaordencompra;
		}
		set {
			mACFfechaordencompra = value;
		}
	}

	AcfINBt_Inventariobienes(){
	}

	AcfINBt_Inventariobienes(){ref int INVid, int ACFid, string ACFactivo, string BUKRS, string SEGMENT, string KOSTL, string ANLKL, string PERNR, string ACTid, string CSTid, string VNRid, Date ACFfincorporacion, Date ACFfcapitalizacion, int ACFvutiltribanio, int ACFvutiltribdia, double ACFvalortrib, double ACFfactortrib, double ACFdepacutrib, int ACfvutilniifanio, int ACFvutilniifdia, double ACFvalorniif, double ACFfactorniif, double ACFdepacuniif, string ACFobra, string ACFord41, string ACFord42, string ACFord43, string ACFord44, string ACFanlue, string ACFcuenta, string ACFcuentadep, string LIFNR, string BLART, string ACFcomprobante, string ACFnotaingreso, Date ACFfechanotaingreso, string ACFordencompra, string ACFobservacion, int AMBid, int UBEid, Date ACFfechacomprobante, Date ACFfechaordencompra)
		mINVid = INVid;
		mACFid = ACFid;
		mACFactivo = ACFactivo;
		mBUKRS = BUKRS;
		mSEGMENT = SEGMENT;
		mKOSTL = KOSTL;
		mANLKL = ANLKL;
		mPERNR = PERNR;
		mACTid = ACTid;
		mCSTid = CSTid;
		mVNRid = VNRid;
		mACFfincorporacion = ACFfincorporacion;
		mACFfcapitalizacion = ACFfcapitalizacion;
		mACFvutiltribanio = ACFvutiltribanio;
		mACFvutiltribdia = ACFvutiltribdia;
		mACFvalortrib = ACFvalortrib;
		mACFfactortrib = ACFfactortrib;
		mACFdepacutrib = ACFdepacutrib;
		mACfvutilniifanio = ACfvutilniifanio;
		mACFvutilniifdia = ACFvutilniifdia;
		mACFvalorniif = ACFvalorniif;
		mACFfactorniif = ACFfactorniif;
		mACFdepacuniif = ACFdepacuniif;
		mACFobra = ACFobra;
		mACFord41 = ACFord41;
		mACFord42 = ACFord42;
		mACFord43 = ACFord43;
		mACFord44 = ACFord44;
		mACFanlue = ACFanlue;
		mACFcuenta = ACFcuenta;
		mACFcuentadep = ACFcuentadep;
		mLIFNR = LIFNR;
		mBLART = BLART;
		mACFcomprobante = ACFcomprobante;
		mACFnotaingreso = ACFnotaingreso;
		mACFfechanotaingreso = ACFfechanotaingreso;
		mACFordencompra = ACFordencompra;
		mACFobservacion = ACFobservacion;
		mAMBid = AMBid;
		mUBEid = UBEid;
		mACFfechacomprobante = ACFfechacomprobante;
		mACFfechaordencompra = ACFfechaordencompra;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
