using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
[AddComponentMenu("NGUI/Examples/Lag Rotation")]
public class ENGMLFILDLF : MonoBehaviour
{
	// Token: 0x06000789 RID: 1929 RVA: 0x00004D34 File Offset: 0x00002F34
	private void HGKPKMMIPLG()
	{
		this.FFNENQKLBPB((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.CIPLINIEDED());
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00004D50 File Offset: 0x00002F50
	public void JCJLCKDCHJE()
	{
		this.FFNENQKLBPB(1026f);
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void BBGHCDGEDEJ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00004D8D File Offset: 0x00002F8D
	private void LQIHPQIKEFE()
	{
		this.OHGIKFKQLQJ((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.FCJDLIPPELL());
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00055C00 File Offset: 0x00053E00
	private void FFNENQKLBPB(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00004DA9 File Offset: 0x00002FA9
	public void OGLCDDHCBED()
	{
		this.PMKIFLQILGM(1000f);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00004DB6 File Offset: 0x00002FB6
	private void JBJBPIBCBQO()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QPEECHQDHFG());
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00004DD2 File Offset: 0x00002FD2
	private void IPFJMEFKGGM()
	{
		this.CMJFJGHJDKE((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.HLMOIFMQOGH());
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00004DEE File Offset: 0x00002FEE
	public void BMOEJHGBPLO()
	{
		this.OHGIKFKQLQJ(121f);
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void QBGOGFJCLEP()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00004DFB File Offset: 0x00002FFB
	private void CBICBMGFHCP()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.KQPPFINIJDG());
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void HBOFMLLODDM()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00004E17 File Offset: 0x00003017
	private void GKBQDQKLPIM()
	{
		this.QEMPIKKQFOM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.CIPLINIEDED());
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00055C00 File Offset: 0x00053E00
	private void QEMPIKKQFOM(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00004DB6 File Offset: 0x00002FB6
	private void MEDIPECIDQP()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QPEECHQDHFG());
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00055C00 File Offset: 0x00053E00
	private void NGFCOJDGFDO(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00004E46 File Offset: 0x00003046
	public void OQKQHMKNJPN()
	{
		this.CMJFJGHJDKE(1121f);
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00004E53 File Offset: 0x00003053
	private void QKLBGBKKGDG()
	{
		this.FFNENQKLBPB((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.PFEELKIHJDG());
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00004E6F File Offset: 0x0000306F
	private void QIHJCOLPLBQ()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.QCDDBMBNQLO());
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void QNGIFIJOQML()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00004E8B File Offset: 0x0000308B
	private void QDHNIMPGNOO()
	{
		this.OHGIKFKQLQJ((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.PFEELKIHJDG());
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00055C00 File Offset: 0x00053E00
	private void OHGIKFKQLQJ(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00055C00 File Offset: 0x00053E00
	private void CQQLHGFCCDP(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00004EA7 File Offset: 0x000030A7
	private void OHQCMCDPHFI()
	{
		this.CQQLHGFCCDP((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.MEJKCDOLEIK());
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00055C00 File Offset: 0x00053E00
	private void PMKIFLQILGM(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void LNHDODMGBKC()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00004EC3 File Offset: 0x000030C3
	private void Update()
	{
		this.PMKIFLQILGM((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG);
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00004D5D File Offset: 0x00002F5D
	private void ODIJQBBOLFI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.KCDIMIMGJEC = this.BLLEFKOLKLP.localRotation;
		this.JNPHBMKOQKQ = this.BLLEFKOLKLP.rotation;
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00055C00 File Offset: 0x00053E00
	private void CMJFJGHJDKE(float JDOGIQGGLKM)
	{
		if (this.BLLEFKOLKLP != null)
		{
			Transform parent = this.BLLEFKOLKLP.parent;
			if (parent != null)
			{
				this.JNPHBMKOQKQ = Quaternion.Slerp(this.JNPHBMKOQKQ, parent.rotation * this.KCDIMIMGJEC, JDOGIQGGLKM * this.KDEMMJKGDJM);
				this.BLLEFKOLKLP.rotation = this.JNPHBMKOQKQ;
			}
		}
	}

	// Token: 0x04000117 RID: 279
	public float KDEMMJKGDJM = 10f;

	// Token: 0x04000118 RID: 280
	public bool FNKBLEMDHKL;

	// Token: 0x04000119 RID: 281
	private Transform BLLEFKOLKLP;

	// Token: 0x0400011A RID: 282
	private Quaternion KCDIMIMGJEC;

	// Token: 0x0400011B RID: 283
	private Quaternion JNPHBMKOQKQ;
}
