public class clsBeAcfEDIt_edificaciondetalle : ICloneable {

	private int mACFid = 0;
	private string mEDIzona = '';
	private string mEDIdescripicion = '';
	private double mEDIfactorasignado = 0.0;
	private double mACFValorIR = 0.0;
	private double mACFTC = 0.0;
	private double mACFCRC = 0.0;
	private double mACFDEPCRC = 0.0;
	private double mACFNETOCRC = 0.0;
	private double mACFvalorniif = 0.0;
	private double mACFdepacuniif = 0.0;
	private double mACFNETOPCGA = 0.0;
	private double mACFDIFCosto = 0.0;
	private double mACFINCCosto = 0.0;
	private double mACFDISCosto = 0.0;
	private double mACFDIFDEP = 0.0;
	private double mACFINCDep = 0.0;
	private double mACFDISDep = 0.0;
	private double mACFDIFNeta = 0.0;
	private double mACFSumDifDed = 0.0;
	private double mACFSumDifGra = 0.0;
	private double mACFSumACTDif = 0.0;
	private double mACFSumPasDif = 0.0;
	private string mACFcuenta = '';
	private string mLOClocal = '';
	private string mRVAcodigo = '';

	public Integer ACFid {
		get {
			return mACFid;
		}
		set {
			mACFid = value;
		}
	}

	public String EDIzona {
		get {
			return mEDIzona;
		}
		set {
			mEDIzona = value;
		}
	}

	public String EDIdescripicion {
		get {
			return mEDIdescripicion;
		}
		set {
			mEDIdescripicion = value;
		}
	}

	public Double EDIfactorasignado {
		get {
			return mEDIfactorasignado;
		}
		set {
			mEDIfactorasignado = value;
		}
	}

	public Double ACFValorIR {
		get {
			return mACFValorIR;
		}
		set {
			mACFValorIR = value;
		}
	}

	public Double ACFTC {
		get {
			return mACFTC;
		}
		set {
			mACFTC = value;
		}
	}

	public Double ACFCRC {
		get {
			return mACFCRC;
		}
		set {
			mACFCRC = value;
		}
	}

	public Double ACFDEPCRC {
		get {
			return mACFDEPCRC;
		}
		set {
			mACFDEPCRC = value;
		}
	}

	public Double ACFNETOCRC {
		get {
			return mACFNETOCRC;
		}
		set {
			mACFNETOCRC = value;
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

	public Double ACFdepacuniif {
		get {
			return mACFdepacuniif;
		}
		set {
			mACFdepacuniif = value;
		}
	}

	public Double ACFNETOPCGA {
		get {
			return mACFNETOPCGA;
		}
		set {
			mACFNETOPCGA = value;
		}
	}

	public Double ACFDIFCosto {
		get {
			return mACFDIFCosto;
		}
		set {
			mACFDIFCosto = value;
		}
	}

	public Double ACFINCCosto {
		get {
			return mACFINCCosto;
		}
		set {
			mACFINCCosto = value;
		}
	}

	public Double ACFDISCosto {
		get {
			return mACFDISCosto;
		}
		set {
			mACFDISCosto = value;
		}
	}

	public Double ACFDIFDEP {
		get {
			return mACFDIFDEP;
		}
		set {
			mACFDIFDEP = value;
		}
	}

	public Double ACFINCDep {
		get {
			return mACFINCDep;
		}
		set {
			mACFINCDep = value;
		}
	}

	public Double ACFDISDep {
		get {
			return mACFDISDep;
		}
		set {
			mACFDISDep = value;
		}
	}

	public Double ACFDIFNeta {
		get {
			return mACFDIFNeta;
		}
		set {
			mACFDIFNeta = value;
		}
	}

	public Double ACFSumDifDed {
		get {
			return mACFSumDifDed;
		}
		set {
			mACFSumDifDed = value;
		}
	}

	public Double ACFSumDifGra {
		get {
			return mACFSumDifGra;
		}
		set {
			mACFSumDifGra = value;
		}
	}

	public Double ACFSumACTDif {
		get {
			return mACFSumACTDif;
		}
		set {
			mACFSumACTDif = value;
		}
	}

	public Double ACFSumPasDif {
		get {
			return mACFSumPasDif;
		}
		set {
			mACFSumPasDif = value;
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

	public String LOClocal {
		get {
			return mLOClocal;
		}
		set {
			mLOClocal = value;
		}
	}

	public String RVAcodigo {
		get {
			return mRVAcodigo;
		}
		set {
			mRVAcodigo = value;
		}
	}

	AcfEDIt_edificaciondetalle(){
	}

	AcfEDIt_edificaciondetalle(){ref int ACFid, string EDIzona, string EDIdescripicion, double EDIfactorasignado, double ACFValorIR, double ACFTC, double ACFCRC, double ACFDEPCRC, double ACFNETOCRC, double ACFvalorniif, double ACFdepacuniif, double ACFNETOPCGA, double ACFDIFCosto, double ACFINCCosto, double ACFDISCosto, double ACFDIFDEP, double ACFINCDep, double ACFDISDep, double ACFDIFNeta, double ACFSumDifDed, double ACFSumDifGra, double ACFSumACTDif, double ACFSumPasDif, string ACFcuenta, string LOClocal, string RVAcodigo)
		mACFid = ACFid;
		mEDIzona = EDIzona;
		mEDIdescripicion = EDIdescripicion;
		mEDIfactorasignado = EDIfactorasignado;
		mACFValorIR = ACFValorIR;
		mACFTC = ACFTC;
		mACFCRC = ACFCRC;
		mACFDEPCRC = ACFDEPCRC;
		mACFNETOCRC = ACFNETOCRC;
		mACFvalorniif = ACFvalorniif;
		mACFdepacuniif = ACFdepacuniif;
		mACFNETOPCGA = ACFNETOPCGA;
		mACFDIFCosto = ACFDIFCosto;
		mACFINCCosto = ACFINCCosto;
		mACFDISCosto = ACFDISCosto;
		mACFDIFDEP = ACFDIFDEP;
		mACFINCDep = ACFINCDep;
		mACFDISDep = ACFDISDep;
		mACFDIFNeta = ACFDIFNeta;
		mACFSumDifDed = ACFSumDifDed;
		mACFSumDifGra = ACFSumDifGra;
		mACFSumACTDif = ACFSumACTDif;
		mACFSumPasDif = ACFSumPasDif;
		mACFcuenta = ACFcuenta;
		mLOClocal = LOClocal;
		mRVAcodigo = RVAcodigo;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
