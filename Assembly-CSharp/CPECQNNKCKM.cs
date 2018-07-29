using System;
using UnityEngine;

// Token: 0x02000041 RID: 65
[AddComponentMenu("NGUI/Examples/Slider Colors")]
public class CPECQNNKCKM : MonoBehaviour
{
	// Token: 0x06000929 RID: 2345 RVA: 0x0005D228 File Offset: 0x0005B428
	private void QKLBGBKKGDG()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0005D348 File Offset: 0x0005B548
	private void EGFFPGCMFOO()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num2 >= 1)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 0], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x0005D468 File Offset: 0x0005B668
	private void EJCHKLBMECH()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[1];
			if (num2 >= 0)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0005D588 File Offset: 0x0005B788
	private void IPFJMEFKGGM()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 0], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x0005D6A8 File Offset: 0x0005B8A8
	private void MEDIPECIDQP()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
	private void Update()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
	private void MOLCLOMMJNQ()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num2 >= 1)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00005136 File Offset: 0x00003336
	private void COOEINBIIIE()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.EGFFPGCMFOO();
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00005156 File Offset: 0x00003356
	private void JCQCNFLNMNP()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.Update();
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00005176 File Offset: 0x00003376
	private void BBGHCDGEDEJ()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.JLBMOKHNDBI();
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00005156 File Offset: 0x00003356
	private void Start()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.Update();
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00005196 File Offset: 0x00003396
	private void NOLQNFCODBK()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.IPFJMEFKGGM();
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x0005DA5C File Offset: 0x0005BC5C
	private void PIQDBCGQDCH()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num2 >= 0)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 0], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0005DB7C File Offset: 0x0005BD7C
	private void EPOCMHBMHGC()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x0005DC9C File Offset: 0x0005BE9C
	private void BJFCILIPEMI()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num2 >= 1)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00005176 File Offset: 0x00003376
	private void QBGOGFJCLEP()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.JLBMOKHNDBI();
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000051B6 File Offset: 0x000033B6
	private void CIJOENOQKCI()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.JBJBPIBCBQO();
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x0005DDBC File Offset: 0x0005BFBC
	private void QIHJCOLPLBQ()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[0];
			if (num2 >= 1)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0005DDBC File Offset: 0x0005BFBC
	private void FLNFKFECNFJ()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[0];
			if (num2 >= 1)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x0005DEDC File Offset: 0x0005C0DC
	private void JLBMOKHNDBI()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num2 >= 1)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x000051D6 File Offset: 0x000033D6
	private void KPKQNOCFGIB()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.MEDIPECIDQP();
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x000051F6 File Offset: 0x000033F6
	private void HPCICOEMKGF()
	{
		this.MPJKDDLCDDH = base.GetComponent<BJQGLGOLMPQ>();
		this.LNMJLFLDCML = base.GetComponent<PHINQNMFEHC>();
		this.EJCHKLBMECH();
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x0005DFFC File Offset: 0x0005C1FC
	private void NPQEGOIJHIL()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[1];
			if (num2 >= 1)
			{
				if (num2 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 0], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x0005E11C File Offset: 0x0005C31C
	private void JBJBPIBCBQO()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.HKDJGHOHBFQ();
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num2 >= 0)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 1], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num2];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			cegfbbhmkoe.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.CEGFBBHMKOE = cegfbbhmkoe;
			return;
		}
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x0005E23C File Offset: 0x0005C43C
	private void GHBFIQFIBKP()
	{
		if (!(this.QDDJBICKQIG == null) && this.BBCJFBHDJFP.Length != 0)
		{
			float num = (!(this.MPJKDDLCDDH != null)) ? this.LNMJLFLDCML.KJNJQMLJELI : this.MPJKDDLCDDH.BGBMIEJJQKC;
			num *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num2 = Mathf.FloorToInt(num);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num2 >= 0)
			{
				if (num2 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num - (float)num2;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num2], this.BBCJFBHDJFP[num2 + 0], t);
				}
				else if (num2 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num2];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.QDDJBICKQIG.CEGFBBHMKOE.a;
			this.QDDJBICKQIG.NONQDHBCIIN(bgbmiejjqkc);
			return;
		}
	}

	// Token: 0x04000133 RID: 307
	public PLQFPBQEPJD QDDJBICKQIG;

	// Token: 0x04000134 RID: 308
	public Color[] BBCJFBHDJFP = new Color[]
	{
		Color.red,
		Color.yellow,
		Color.green
	};

	// Token: 0x04000135 RID: 309
	private BJQGLGOLMPQ MPJKDDLCDDH;

	// Token: 0x04000136 RID: 310
	private PHINQNMFEHC LNMJLFLDCML;
}
