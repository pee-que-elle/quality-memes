using System;
using UnityEngine;

// Token: 0x0200003E RID: 62
[AddComponentMenu("NGUI/Examples/Spin")]
public class Spin : MonoBehaviour
{
	// Token: 0x060008AA RID: 2218 RVA: 0x00004FFB File Offset: 0x000031FB
	private void IKHIQQKHILB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00005015 File Offset: 0x00003215
	private void Update()
	{
		if (this.BJBIINFKIDN == null)
		{
			this.JJBFNGQOEPB((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.GPFIDEJEMEG);
		}
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0005AF74 File Offset: 0x00059174
	public void NIHKPHHJNJJ(float JDOGIQGGLKM)
	{
		JDOGIQGGLKM *= 208f;
		Quaternion rhs = Quaternion.Euler(this.LHOQNGLKCKM * JDOGIQGGLKM);
		if (this.BJBIINFKIDN == null)
		{
			this.BLLEFKOLKLP.rotation = this.BLLEFKOLKLP.rotation * rhs;
		}
		else
		{
			this.BJBIINFKIDN.MoveRotation(this.BJBIINFKIDN.rotation * rhs);
		}
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0000503F File Offset: 0x0000323F
	private void NEMMPHBMFEH()
	{
		if (this.BJBIINFKIDN != null)
		{
			this.JJBFNGQOEPB(Time.deltaTime);
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0000507C File Offset: 0x0000327C
	private void QFFJMIOJENJ()
	{
		if (this.BJBIINFKIDN == null)
		{
			this.NIHKPHHJNJJ((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.CIPLINIEDED());
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00004FFB File Offset: 0x000031FB
	private void COOEINBIIIE()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0000503F File Offset: 0x0000323F
	private void FixedUpdate()
	{
		if (this.BJBIINFKIDN != null)
		{
			this.JJBFNGQOEPB(Time.deltaTime);
		}
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x000050A6 File Offset: 0x000032A6
	private void FDQEKLHIKEJ()
	{
		if (this.BJBIINFKIDN != null)
		{
			this.NKFENDNGJDE(Time.deltaTime);
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00004FFB File Offset: 0x000031FB
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x000050A6 File Offset: 0x000032A6
	private void LLHBHNHPJBL()
	{
		if (this.BJBIINFKIDN != null)
		{
			this.NKFENDNGJDE(Time.deltaTime);
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00004FFB File Offset: 0x000031FB
	private void NOLQNFCODBK()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00004FFB File Offset: 0x000031FB
	private void KPKQNOCFGIB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x000050C1 File Offset: 0x000032C1
	private void QKLBGBKKGDG()
	{
		if (this.BJBIINFKIDN == null)
		{
			this.NIHKPHHJNJJ((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.PFEELKIHJDG());
		}
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00004FFB File Offset: 0x000031FB
	private void FOPKBNIOGCP()
	{
		this.BLLEFKOLKLP = base.transform;
		this.BJBIINFKIDN = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x000050EB File Offset: 0x000032EB
	private void QIHJCOLPLBQ()
	{
		if (this.BJBIINFKIDN == null)
		{
			this.NKFENDNGJDE((!this.FNKBLEMDHKL) ? Time.deltaTime : JMIOBJFFGBN.EDEPQCIGFOL());
		}
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0005AFE4 File Offset: 0x000591E4
	public void JJBFNGQOEPB(float JDOGIQGGLKM)
	{
		JDOGIQGGLKM *= 360f;
		Quaternion rhs = Quaternion.Euler(this.LHOQNGLKCKM * JDOGIQGGLKM);
		if (this.BJBIINFKIDN == null)
		{
			this.BLLEFKOLKLP.rotation = this.BLLEFKOLKLP.rotation * rhs;
		}
		else
		{
			this.BJBIINFKIDN.MoveRotation(this.BJBIINFKIDN.rotation * rhs);
		}
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0005B054 File Offset: 0x00059254
	public void NKFENDNGJDE(float JDOGIQGGLKM)
	{
		JDOGIQGGLKM *= 19f;
		Quaternion rhs = Quaternion.Euler(this.LHOQNGLKCKM * JDOGIQGGLKM);
		if (this.BJBIINFKIDN == null)
		{
			this.BLLEFKOLKLP.rotation = this.BLLEFKOLKLP.rotation * rhs;
		}
		else
		{
			this.BJBIINFKIDN.MoveRotation(this.BJBIINFKIDN.rotation * rhs);
		}
	}

	// Token: 0x0400012C RID: 300
	public Vector3 LHOQNGLKCKM = new Vector3(0f, 0.1f, 0f);

	// Token: 0x0400012D RID: 301
	public bool FNKBLEMDHKL;

	// Token: 0x0400012E RID: 302
	private Rigidbody BJBIINFKIDN;

	// Token: 0x0400012F RID: 303
	private Transform BLLEFKOLKLP;
}
