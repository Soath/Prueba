public class clsBeAcfAMBt_Ambiente : ICloneable {

	private int mLOCid = 0;
	private int mAMBid = 0;
	private string mAMBambiente = '';

	public Integer LOCid {
		get {
			return mLOCid;
		}
		set {
			mLOCid = value;
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

	public String AMBambiente {
		get {
			return mAMBambiente;
		}
		set {
			mAMBambiente = value;
		}
	}

	AcfAMBt_Ambiente(){
	}

	AcfAMBt_Ambiente(){ref int LOCid, int AMBid, string AMBambiente)
		mLOCid = LOCid;
		mAMBid = AMBid;
		mAMBambiente = AMBambiente;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
