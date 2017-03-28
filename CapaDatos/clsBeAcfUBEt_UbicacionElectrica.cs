public class clsBeAcfUBEt_UbicacionElectrica : ICloneable {

	private int mUBEcodigogis = 0;
	private string mUBEobra = '';
	private string mKOSTL = '';
	private string mVNRid = '';
	private string mSELid = '';
	private int mUBEset = 0;
	private string mUBEsetetq = '';
	private int mUBEalimentador = 0;
	private string mUBEalimentadoretq = '';
	private int mUBEsed = 0;
	private string mUBEsedetq = '';
	private int mUBEcircuito = 0;
	private string mUBEcircuitoetq = '';
	private int mUBEpuntoi = 0;
	private string mUBEpuntoietq = '';
	private int mUBEpuntof = 0;
	private string mUBEpuntofetq = '';
	private int mUBEid = 0;
	private int mACFid = 0;

	public Integer UBEcodigogis {
		get {
			return mUBEcodigogis;
		}
		set {
			mUBEcodigogis = value;
		}
	}

	public String UBEobra {
		get {
			return mUBEobra;
		}
		set {
			mUBEobra = value;
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

	public String VNRid {
		get {
			return mVNRid;
		}
		set {
			mVNRid = value;
		}
	}

	public String SELid {
		get {
			return mSELid;
		}
		set {
			mSELid = value;
		}
	}

	public Integer UBEset {
		get {
			return mUBEset;
		}
		set {
			mUBEset = value;
		}
	}

	public String UBEsetetq {
		get {
			return mUBEsetetq;
		}
		set {
			mUBEsetetq = value;
		}
	}

	public Integer UBEalimentador {
		get {
			return mUBEalimentador;
		}
		set {
			mUBEalimentador = value;
		}
	}

	public String UBEalimentadoretq {
		get {
			return mUBEalimentadoretq;
		}
		set {
			mUBEalimentadoretq = value;
		}
	}

	public Integer UBEsed {
		get {
			return mUBEsed;
		}
		set {
			mUBEsed = value;
		}
	}

	public String UBEsedetq {
		get {
			return mUBEsedetq;
		}
		set {
			mUBEsedetq = value;
		}
	}

	public Integer UBEcircuito {
		get {
			return mUBEcircuito;
		}
		set {
			mUBEcircuito = value;
		}
	}

	public String UBEcircuitoetq {
		get {
			return mUBEcircuitoetq;
		}
		set {
			mUBEcircuitoetq = value;
		}
	}

	public Integer UBEpuntoi {
		get {
			return mUBEpuntoi;
		}
		set {
			mUBEpuntoi = value;
		}
	}

	public String UBEpuntoietq {
		get {
			return mUBEpuntoietq;
		}
		set {
			mUBEpuntoietq = value;
		}
	}

	public Integer UBEpuntof {
		get {
			return mUBEpuntof;
		}
		set {
			mUBEpuntof = value;
		}
	}

	public String UBEpuntofetq {
		get {
			return mUBEpuntofetq;
		}
		set {
			mUBEpuntofetq = value;
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

	public Integer ACFid {
		get {
			return mACFid;
		}
		set {
			mACFid = value;
		}
	}

	AcfUBEt_UbicacionElectrica(){
	}

	AcfUBEt_UbicacionElectrica(){ref int UBEcodigogis, string UBEobra, string KOSTL, string VNRid, string SELid, int UBEset, string UBEsetetq, int UBEalimentador, string UBEalimentadoretq, int UBEsed, string UBEsedetq, int UBEcircuito, string UBEcircuitoetq, int UBEpuntoi, string UBEpuntoietq, int UBEpuntof, string UBEpuntofetq, int UBEid, int ACFid)
		mUBEcodigogis = UBEcodigogis;
		mUBEobra = UBEobra;
		mKOSTL = KOSTL;
		mVNRid = VNRid;
		mSELid = SELid;
		mUBEset = UBEset;
		mUBEsetetq = UBEsetetq;
		mUBEalimentador = UBEalimentador;
		mUBEalimentadoretq = UBEalimentadoretq;
		mUBEsed = UBEsed;
		mUBEsedetq = UBEsedetq;
		mUBEcircuito = UBEcircuito;
		mUBEcircuitoetq = UBEcircuitoetq;
		mUBEpuntoi = UBEpuntoi;
		mUBEpuntoietq = UBEpuntoietq;
		mUBEpuntof = UBEpuntof;
		mUBEpuntofetq = UBEpuntofetq;
		mUBEid = UBEid;
		mACFid = ACFid;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
