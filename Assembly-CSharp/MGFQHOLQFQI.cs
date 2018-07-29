using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class MGFQHOLQFQI : MonoBehaviour
{
	// Token: 0x06000766 RID: 1894 RVA: 0x00055B10 File Offset: 0x00053D10
	private void HNKHCOKPKJM(float JDOGIQGGLKM)
	{
		Transform parent = this.BLLEFKOLKLP.parent;
		if (parent != null)
		{
			Vector3 vector = parent.position + parent.rotation * this.KCDIMIMGJEC;
			this.JNPHBMKOQKQ.x = Mathf.Lerp(this.JNPHBMKOQKQ.x, vector.x, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.x));
			this.JNPHBMKOQKQ.y = Mathf.Lerp(this.JNPHBMKOQKQ.y, vector.y, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.y));
			this.JNPHBMKOQKQ.z = Mathf.Lerp(this.JNPHBMKOQKQ.z, vector.z, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.z));
			this.BLLEFKOLKLP.position = this.JNPHBMKOQKQ;
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00004B7E File Offset: 0x00002D7E
	public void OGLCDDHCBED()
	{
		this.PMKIFLQILGM(1000f);
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00004B8B File Offset: 0x00002D8B
	public void FELKKIGKOCG()
	{
		this.PMKIFLQILGM(1276f);
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00004B98 File Offset: 0x00002D98
	public void LEKOMPFHLIP()
	{
		this.MBIJFNHKCIH(902f);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00004BA5 File Offset: 0x00002DA5
	public void ECNCOKPQNCB()
	{
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.position;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localPosition;
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00055B10 File Offset: 0x00053D10
	private void MBIJFNHKCIH(float JDOGIQGGLKM)
	{
		Transform parent = this.BLLEFKOLKLP.parent;
		if (parent != null)
		{
			Vector3 vector = parent.position + parent.rotation * this.KCDIMIMGJEC;
			this.JNPHBMKOQKQ.x = Mathf.Lerp(this.JNPHBMKOQKQ.x, vector.x, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.x));
			this.JNPHBMKOQKQ.y = Mathf.Lerp(this.JNPHBMKOQKQ.y, vector.y, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.y));
			this.JNPHBMKOQKQ.z = Mathf.Lerp(this.JNPHBMKOQKQ.z, vector.z, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.z));
			this.BLLEFKOLKLP.position = this.JNPHBMKOQKQ;
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00004BC9 File Offset: 0x00002DC9
	private void FOLBFDNJLII()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00004BF9 File Offset: 0x00002DF9
	public void JMCNHFJNPKE()
	{
		this.MBIJFNHKCIH(1273f);
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00004C06 File Offset: 0x00002E06
	private void JLBMOKHNDBI()
	{
		this.HNKHCOKPKJM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QCDDBMBNQLO());
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00004C22 File Offset: 0x00002E22
	private void FLNFKFECNFJ()
	{
		this.MBIJFNHKCIH((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCJDLIPPELL());
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00004C3E File Offset: 0x00002E3E
	private void CLNOPBFEBID()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCJDLIPPELL());
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00004BC9 File Offset: 0x00002DC9
	private void Awake()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00004C5A File Offset: 0x00002E5A
	private void DLBNQMKQILC()
	{
		this.MBIJFNHKCIH((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QMLMHDJFJOP());
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00004C76 File Offset: 0x00002E76
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		this.KGCHHINLEBP();
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00004BC9 File Offset: 0x00002DC9
	private void CBIFGBNDMHB()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00004BC9 File Offset: 0x00002DC9
	private void CHKQIFFEEPL()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00004C85 File Offset: 0x00002E85
	private void BLLKOOJOHMG()
	{
		if (this.PNBOOLEOKCI)
		{
			this.IJCKDEQQQKI();
		}
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00004C95 File Offset: 0x00002E95
	private void GCIOQGPOLBK()
	{
		if (this.PNBOOLEOKCI)
		{
			this.GFJNEONGQCO();
		}
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00004BC9 File Offset: 0x00002DC9
	private void BEHGFNEDJDF()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00004CA5 File Offset: 0x00002EA5
	public void NKGHIGPDNNK()
	{
		this.HNKHCOKPKJM(124f);
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00055B10 File Offset: 0x00053D10
	private void PMKIFLQILGM(float JDOGIQGGLKM)
	{
		Transform parent = this.BLLEFKOLKLP.parent;
		if (parent != null)
		{
			Vector3 vector = parent.position + parent.rotation * this.KCDIMIMGJEC;
			this.JNPHBMKOQKQ.x = Mathf.Lerp(this.JNPHBMKOQKQ.x, vector.x, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.x));
			this.JNPHBMKOQKQ.y = Mathf.Lerp(this.JNPHBMKOQKQ.y, vector.y, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.y));
			this.JNPHBMKOQKQ.z = Mathf.Lerp(this.JNPHBMKOQKQ.z, vector.z, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.z));
			this.BLLEFKOLKLP.position = this.JNPHBMKOQKQ;
		}
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00004CB2 File Offset: 0x00002EB2
	private void CIJOENOQKCI()
	{
		this.PNBOOLEOKCI = true;
		this.MIOOBJIGKGF();
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00004CC1 File Offset: 0x00002EC1
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.KGCHHINLEBP();
		}
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00004CD1 File Offset: 0x00002ED1
	private void Update()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG);
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00004CED File Offset: 0x00002EED
	private void OEFEKHJBGPN()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.DEHFGOQHJCP());
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00004BA5 File Offset: 0x00002DA5
	public void IJCKDEQQQKI()
	{
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.position;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localPosition;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00055B10 File Offset: 0x00053D10
	private void DHLGNLGNGLJ(float JDOGIQGGLKM)
	{
		Transform parent = this.BLLEFKOLKLP.parent;
		if (parent != null)
		{
			Vector3 vector = parent.position + parent.rotation * this.KCDIMIMGJEC;
			this.JNPHBMKOQKQ.x = Mathf.Lerp(this.JNPHBMKOQKQ.x, vector.x, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.x));
			this.JNPHBMKOQKQ.y = Mathf.Lerp(this.JNPHBMKOQKQ.y, vector.y, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.y));
			this.JNPHBMKOQKQ.z = Mathf.Lerp(this.JNPHBMKOQKQ.z, vector.z, Mathf.Clamp01(JDOGIQGGLKM * this.KDEMMJKGDJM.z));
			this.BLLEFKOLKLP.position = this.JNPHBMKOQKQ;
		}
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00004BA5 File Offset: 0x00002DA5
	public void KGCHHINLEBP()
	{
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.position;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localPosition;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00004D09 File Offset: 0x00002F09
	private void NOLQNFCODBK()
	{
		this.PNBOOLEOKCI = true;
		this.IJCKDEQQQKI();
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00004D18 File Offset: 0x00002F18
	private void QNGIFIJOQML()
	{
		this.PNBOOLEOKCI = false;
		this.MIOOBJIGKGF();
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00004BA5 File Offset: 0x00002DA5
	public void MIOOBJIGKGF()
	{
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.position;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localPosition;
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00004BA5 File Offset: 0x00002DA5
	public void GFJNEONGQCO()
	{
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.position;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localPosition;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00004D27 File Offset: 0x00002F27
	public void QMHQGNKNEIM()
	{
		this.HNKHCOKPKJM(1462f);
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00004C95 File Offset: 0x00002E95
	private void IIKNHGOMQEG()
	{
		if (this.PNBOOLEOKCI)
		{
			this.GFJNEONGQCO();
		}
	}

	// Token: 0x04000111 RID: 273
	public Vector3 KDEMMJKGDJM = new Vector3(10f, 10f, 10f);

	// Token: 0x04000112 RID: 274
	public bool FNKBLEMDHKL;

	// Token: 0x04000113 RID: 275
	private Transform BLLEFKOLKLP;

	// Token: 0x04000114 RID: 276
	private Vector3 KCDIMIMGJEC;

	// Token: 0x04000115 RID: 277
	private Vector3 JNPHBMKOQKQ;

	// Token: 0x04000116 RID: 278
	private bool PNBOOLEOKCI;
}
