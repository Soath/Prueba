public class clsBeAcfSPNt_Supranumero : ICloneable {

	private string mV_T087U_ANLUE = '';
	private string mV_T087U_ANLUE_TXT = '';

	public String V_T087U_ANLUE {
		get {
			return mV_T087U_ANLUE;
		}
		set {
			mV_T087U_ANLUE = value;
		}
	}

	public String V_T087U_ANLUE_TXT {
		get {
			return mV_T087U_ANLUE_TXT;
		}
		set {
			mV_T087U_ANLUE_TXT = value;
		}
	}

	AcfSPNt_Supranumero(){
	}

	AcfSPNt_Supranumero(){ref string V_T087U_ANLUE, string V_T087U_ANLUE_TXT)
		mV_T087U_ANLUE = V_T087U_ANLUE;
		mV_T087U_ANLUE_TXT = V_T087U_ANLUE_TXT;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
