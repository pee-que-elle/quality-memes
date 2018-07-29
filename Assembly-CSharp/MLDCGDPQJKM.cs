using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000201 RID: 513
public class MLDCGDPQJKM
{
	// Token: 0x060043BC RID: 17340 RVA: 0x0001CCA9 File Offset: 0x0001AEA9
	public void NHBJMGDNCBM(ENMOIEBMHNJ DQLNIPIGLHK)
	{
		if (this.HJHOIHBLGLN == null)
		{
			this.HJHOIHBLGLN = DQLNIPIGLHK;
			return;
		}
		if (this.GIEEFBDBQPK.Count == 0)
		{
			this.EGCBBBODPQF = DateTime.Now;
		}
		this.GIEEFBDBQPK.Enqueue(DQLNIPIGLHK);
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x00212D08 File Offset: 0x00210F08
	private float OMDIDCGOIOF()
	{
		float num = 649f;
		Vector3 b = this.HJHOIHBLGLN.ICHJIBEBKDJ();
		foreach (ENMOIEBMHNJ enmoiebmhnj in this.GIEEFBDBQPK)
		{
			num += Vector3.Distance(enmoiebmhnj.GKFFHLQHDGM(), b);
			b = enmoiebmhnj.NBQPNONPHMN();
		}
		return num;
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x00212D80 File Offset: 0x00210F80
	public ENMOIEBMHNJ FNBNIBJJMMN()
	{
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		float num = 1794f;
		float dpiqmbndhgg = this.DPIQMBNDHGG;
		if (dpiqmbndhgg >= 954f)
		{
			num *= dpiqmbndhgg / 380f;
		}
		float t = this.IJPLEBJMBKK((float)(DateTime.Now - this.EGCBBBODPQF).TotalSeconds, num);
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.GIEEFBDBQPK.Peek();
		ENMOIEBMHNJ enmoiebmhnj2 = new ENMOIEBMHNJ();
		enmoiebmhnj2.BIJEQKKMFMD(Vector3.Lerp(this.HJHOIHBLGLN.NBQPNONPHMN(), enmoiebmhnj.ICHJIBEBKDJ(), t));
		enmoiebmhnj2.GLLQGMHOJGF(Quaternion.Lerp(this.HJHOIHBLGLN.QKNPJDIBCGG(), enmoiebmhnj.QKNPJDIBCGG(), t));
		return enmoiebmhnj2;
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x00212E4C File Offset: 0x0021104C
	private float BGPMDGCIFCI(float DIHDBMHGBHO, float HBJHLLBLPIL)
	{
		DIHDBMHGBHO *= HBJHLLBLPIL;
		while (DIHDBMHGBHO > 1f && this.GIEEFBDBQPK.Count > 0)
		{
			this.HJHOIHBLGLN = this.GIEEFBDBQPK.Dequeue();
			this.EGCBBBODPQF = this.EGCBBBODPQF.Add(TimeSpan.FromSeconds((double)(1f / HBJHLLBLPIL)));
			DIHDBMHGBHO -= 1f;
		}
		return Mathf.Clamp01(DIHDBMHGBHO);
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x00212EB4 File Offset: 0x002110B4
	public ENMOIEBMHNJ CGDGNLGEKIQ()
	{
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		float num = 413f;
		float num2 = this.OMDIDCGOIOF();
		if (num2 >= 91f)
		{
			num *= num2 / 1873f;
		}
		float t = this.BGPMDGCIFCI((float)(DateTime.Now - this.EGCBBBODPQF).TotalSeconds, num);
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.GIEEFBDBQPK.Peek();
		ENMOIEBMHNJ enmoiebmhnj2 = new ENMOIEBMHNJ();
		enmoiebmhnj2.HOICELOGMEJ(Vector3.Lerp(this.HJHOIHBLGLN.JCBDILOKJCQ(), enmoiebmhnj.PELCNBCMNFH, t));
		enmoiebmhnj2.NLEJGIBJQOP(Quaternion.Lerp(this.HJHOIHBLGLN.KEBHQDCBQKM(), enmoiebmhnj.KEBHQDCBQKM(), t));
		return enmoiebmhnj2;
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x00212F80 File Offset: 0x00211180
	private float PIQMBMJGJPN()
	{
		float num = 192f;
		Vector3 b = this.HJHOIHBLGLN.JCBDILOKJCQ();
		foreach (ENMOIEBMHNJ enmoiebmhnj in this.GIEEFBDBQPK)
		{
			num += Vector3.Distance(enmoiebmhnj.HMHEBIDMCHM(), b);
			b = enmoiebmhnj.HMHEBIDMCHM();
		}
		return num;
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x00212FF8 File Offset: 0x002111F8
	private float IJPLEBJMBKK(float DIHDBMHGBHO, float HBJHLLBLPIL)
	{
		DIHDBMHGBHO *= HBJHLLBLPIL;
		while (DIHDBMHGBHO > 1992f && this.GIEEFBDBQPK.Count > 0)
		{
			this.HJHOIHBLGLN = this.GIEEFBDBQPK.Dequeue();
			this.EGCBBBODPQF = this.EGCBBBODPQF.Add(TimeSpan.FromSeconds((double)(1729f / HBJHLLBLPIL)));
			DIHDBMHGBHO -= 572f;
		}
		return Mathf.Clamp01(DIHDBMHGBHO);
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x060043C4 RID: 17348 RVA: 0x00213060 File Offset: 0x00211260
	private float DPIQMBNDHGG
	{
		get
		{
			float num = 0f;
			Vector3 pelcnbcmnfh = this.HJHOIHBLGLN.PELCNBCMNFH;
			foreach (ENMOIEBMHNJ enmoiebmhnj in this.GIEEFBDBQPK)
			{
				num += Vector3.Distance(enmoiebmhnj.PELCNBCMNFH, pelcnbcmnfh);
				pelcnbcmnfh = enmoiebmhnj.PELCNBCMNFH;
			}
			return num;
		}
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x002130D8 File Offset: 0x002112D8
	private float MBOGCDJOCEQ(float DIHDBMHGBHO, float HBJHLLBLPIL)
	{
		DIHDBMHGBHO *= HBJHLLBLPIL;
		while (DIHDBMHGBHO > 278f && this.GIEEFBDBQPK.Count > 0)
		{
			this.HJHOIHBLGLN = this.GIEEFBDBQPK.Dequeue();
			this.EGCBBBODPQF = this.EGCBBBODPQF.Add(TimeSpan.FromSeconds((double)(1848f / HBJHLLBLPIL)));
			DIHDBMHGBHO -= 506f;
		}
		return Mathf.Clamp01(DIHDBMHGBHO);
	}

	// Token: 0x060043C6 RID: 17350 RVA: 0x00213140 File Offset: 0x00211340
	private float QJLFPGHLKCM(float DIHDBMHGBHO, float HBJHLLBLPIL)
	{
		DIHDBMHGBHO *= HBJHLLBLPIL;
		while (DIHDBMHGBHO > 1247f && this.GIEEFBDBQPK.Count > 1)
		{
			this.HJHOIHBLGLN = this.GIEEFBDBQPK.Dequeue();
			this.EGCBBBODPQF = this.EGCBBBODPQF.Add(TimeSpan.FromSeconds((double)(895f / HBJHLLBLPIL)));
			DIHDBMHGBHO -= 1613f;
		}
		return Mathf.Clamp01(DIHDBMHGBHO);
	}

	// Token: 0x060043C7 RID: 17351 RVA: 0x002131A8 File Offset: 0x002113A8
	public ENMOIEBMHNJ CLJLDIGMNQI()
	{
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		float num = 2f;
		float dpiqmbndhgg = this.DPIQMBNDHGG;
		if (dpiqmbndhgg >= 26f)
		{
			num *= dpiqmbndhgg / 26f;
		}
		float t = this.BGPMDGCIFCI((float)(DateTime.Now - this.EGCBBBODPQF).TotalSeconds, num);
		if (this.GIEEFBDBQPK.Count == 0)
		{
			return this.HJHOIHBLGLN;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.GIEEFBDBQPK.Peek();
		return new ENMOIEBMHNJ
		{
			PELCNBCMNFH = Vector3.Lerp(this.HJHOIHBLGLN.PELCNBCMNFH, enmoiebmhnj.PELCNBCMNFH, t),
			CDDKNNJMCMP = Quaternion.Lerp(this.HJHOIHBLGLN.CDDKNNJMCMP, enmoiebmhnj.CDDKNNJMCMP, t)
		};
	}

	// Token: 0x060043C8 RID: 17352 RVA: 0x0001CCA9 File Offset: 0x0001AEA9
	public void LHQECHHMOGD(ENMOIEBMHNJ DQLNIPIGLHK)
	{
		if (this.HJHOIHBLGLN == null)
		{
			this.HJHOIHBLGLN = DQLNIPIGLHK;
			return;
		}
		if (this.GIEEFBDBQPK.Count == 0)
		{
			this.EGCBBBODPQF = DateTime.Now;
		}
		this.GIEEFBDBQPK.Enqueue(DQLNIPIGLHK);
	}

	// Token: 0x04000EA0 RID: 3744
	private const float JFOBMOMOCDK = 2f;

	// Token: 0x04000EA1 RID: 3745
	private Queue<ENMOIEBMHNJ> GIEEFBDBQPK = new Queue<ENMOIEBMHNJ>();

	// Token: 0x04000EA2 RID: 3746
	private ENMOIEBMHNJ HJHOIHBLGLN;

	// Token: 0x04000EA3 RID: 3747
	private DateTime EGCBBBODPQF;
}
