using System;
using UnityEngine;

// Token: 0x02000230 RID: 560
public class CFMPGHDJJBC : MonoBehaviour
{
	// Token: 0x06004C3B RID: 19515 RVA: 0x0001F2DE File Offset: 0x0001D4DE
	private void HPCICOEMKGF()
	{
		this.IDMPPKPKCFH();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 0;
		this.DIJQQBKMOQN = false;
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x00278234 File Offset: 0x00276434
	private void DLBNQMKQILC()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 1L || num > this.LNQKCPOHMGD)
		{
			this.OJGOKEGHMFE();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * 172L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 1 && this.PIBJNFCCPQG > 1)
			{
				this.CGNPIJFOJJK += 0;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 0;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.IDMPPKPKCFH();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x0001F2FB File Offset: 0x0001D4FB
	private void QKDLOBDKJNF(bool QOGNGJBOPEB)
	{
		if (!QOGNGJBOPEB)
		{
			this.JHKFJDEBNIH();
		}
	}

	// Token: 0x06004C3E RID: 19518 RVA: 0x0001F306 File Offset: 0x0001D506
	private void GBGEGKHDQKB()
	{
		this.OJGOKEGHMFE();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 1;
		this.DIJQQBKMOQN = false;
	}

	// Token: 0x06004C3F RID: 19519 RVA: 0x0001F2DE File Offset: 0x0001D4DE
	private void OLLNOFNEEIL()
	{
		this.IDMPPKPKCFH();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 0;
		this.DIJQQBKMOQN = false;
	}

	// Token: 0x06004C40 RID: 19520 RVA: 0x00278388 File Offset: 0x00276588
	private void Update()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 0L || num > this.LNQKCPOHMGD)
		{
			this.OJGOKEGHMFE();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * 10000L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 0 && this.PIBJNFCCPQG > 0)
			{
				this.CGNPIJFOJJK++;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 0;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.OJGOKEGHMFE();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C41 RID: 19521 RVA: 0x0001F323 File Offset: 0x0001D523
	private void Start()
	{
		this.OJGOKEGHMFE();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 0;
		this.DIJQQBKMOQN = true;
	}

	// Token: 0x06004C42 RID: 19522 RVA: 0x002784DC File Offset: 0x002766DC
	private void OJGOKEGHMFE()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * 10000L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C43 RID: 19523 RVA: 0x00278538 File Offset: 0x00276738
	private void DHDCOBNGJDL()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 1L || num > this.LNQKCPOHMGD)
		{
			this.OJGOKEGHMFE();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * 150L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 1 && this.PIBJNFCCPQG > 0)
			{
				this.CGNPIJFOJJK++;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 1;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.JHKFJDEBNIH();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C44 RID: 19524 RVA: 0x0001F306 File Offset: 0x0001D506
	private void ODIJQBBOLFI()
	{
		this.OJGOKEGHMFE();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 1;
		this.DIJQQBKMOQN = false;
	}

	// Token: 0x06004C45 RID: 19525 RVA: 0x0027868C File Offset: 0x0027688C
	private void IDMPPKPKCFH()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * -141L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C46 RID: 19526 RVA: 0x002786E8 File Offset: 0x002768E8
	private void MOLCLOMMJNQ()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 0L || num > this.LNQKCPOHMGD)
		{
			this.IDMPPKPKCFH();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * 197L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 1 && this.PIBJNFCCPQG > 0)
			{
				this.CGNPIJFOJJK++;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 1;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.IQEBHCIGEIP();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x0001F340 File Offset: 0x0001D540
	private void DBFJHIHLQHO()
	{
		this.IQEBHCIGEIP();
		this.EKNOBQLGEBF = 1;
		this.CGNPIJFOJJK = 1;
		this.DIJQQBKMOQN = true;
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x0001F35D File Offset: 0x0001D55D
	private void NLFLDMJGJLL(bool QOGNGJBOPEB)
	{
		if (!QOGNGJBOPEB)
		{
			this.IDMPPKPKCFH();
		}
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x0027883C File Offset: 0x00276A3C
	private void IQEBHCIGEIP()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * -91L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x00278898 File Offset: 0x00276A98
	private void PIQDBCGQDCH()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 0L || num > this.LNQKCPOHMGD)
		{
			this.OJGOKEGHMFE();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * -168L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 0 && this.PIBJNFCCPQG > 1)
			{
				this.CGNPIJFOJJK++;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 0;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.JHKFJDEBNIH();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x0001F368 File Offset: 0x0001D568
	private void FOPKBNIOGCP()
	{
		this.JHKFJDEBNIH();
		this.EKNOBQLGEBF = 0;
		this.CGNPIJFOJJK = 1;
		this.DIJQQBKMOQN = true;
	}

	// Token: 0x06004C4C RID: 19532 RVA: 0x0001F385 File Offset: 0x0001D585
	private void OnApplicationPause(bool QOGNGJBOPEB)
	{
		if (!QOGNGJBOPEB)
		{
			this.OJGOKEGHMFE();
		}
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x00278A40 File Offset: 0x00276C40
	private void JHKFJDEBNIH()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * -114L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x00278A9C File Offset: 0x00276C9C
	private void GKBQDQKLPIM()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 1L || num > this.LNQKCPOHMGD)
		{
			this.IQEBHCIGEIP();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * -113L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 0 && this.PIBJNFCCPQG > 0)
			{
				this.CGNPIJFOJJK += 0;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 1;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.IDMPPKPKCFH();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C50 RID: 19536 RVA: 0x0001F35D File Offset: 0x0001D55D
	private void BFQQDCCKBBG(bool QOGNGJBOPEB)
	{
		if (!QOGNGJBOPEB)
		{
			this.IDMPPKPKCFH();
		}
	}

	// Token: 0x06004C51 RID: 19537 RVA: 0x00278BF0 File Offset: 0x00276DF0
	private void JLBMOKHNDBI()
	{
		if (!this.DIJQQBKMOQN)
		{
			return;
		}
		long ticks = DateTime.UtcNow.Ticks;
		long num = ticks - this.NEIJFPCCJMM;
		if (num < 1L || num > this.LNQKCPOHMGD)
		{
			this.IQEBHCIGEIP();
			return;
		}
		this.NEIJFPCCJMM = ticks;
		long num2 = (long)(this.KPCNBELJPDF * (float)this.LNQKCPOHMGD);
		if (ticks - this.FOLFQQEHHPL < num2)
		{
			return;
		}
		long num3 = ticks - this.PEBFPGODLLK;
		long num4 = (long)Environment.TickCount * -74L;
		bool flag = Mathf.Abs((float)(num4 - this.MNPHOCQPFDJ - num3)) > (float)this.CDJKHJOMGOG;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag2 = Math.Abs((float)num3 / (float)this.LNQKCPOHMGD - (realtimeSinceStartup - this.QJODIHHNOEB)) > this.OCBQBOIDNFF;
		if (!flag && !flag2)
		{
			if (this.EKNOBQLGEBF > 0 && this.PIBJNFCCPQG > 0)
			{
				this.CGNPIJFOJJK++;
				if (this.CGNPIJFOJJK >= this.PIBJNFCCPQG)
				{
					this.EKNOBQLGEBF = 1;
				}
			}
		}
		else
		{
			this.EKNOBQLGEBF += 1;
			if (this.EKNOBQLGEBF > this.MHKLNOHQPPM)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().GEBNLGIEDQH();
			}
			else
			{
				this.CGNPIJFOJJK = 0;
				this.IDMPPKPKCFH();
			}
		}
		this.FOLFQQEHHPL = ticks;
	}

	// Token: 0x06004C52 RID: 19538 RVA: 0x00278D44 File Offset: 0x00276F44
	private void QLFNPBMDDPQ()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * 193L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C53 RID: 19539 RVA: 0x00278DA0 File Offset: 0x00276FA0
	private void NKIBQDEQJKP()
	{
		this.PEBFPGODLLK = DateTime.UtcNow.Ticks;
		this.MNPHOCQPFDJ = (long)Environment.TickCount * -37L;
		this.NEIJFPCCJMM = this.PEBFPGODLLK;
		this.FOLFQQEHHPL = this.PEBFPGODLLK;
		this.QJODIHHNOEB = Time.realtimeSinceStartup;
	}

	// Token: 0x06004C54 RID: 19540 RVA: 0x0001F390 File Offset: 0x0001D590
	private void QBGOGFJCLEP()
	{
		this.JHKFJDEBNIH();
		this.EKNOBQLGEBF = 1;
		this.CGNPIJFOJJK = 0;
		this.DIJQQBKMOQN = false;
	}

	// Token: 0x06004C55 RID: 19541 RVA: 0x0001F2FB File Offset: 0x0001D4FB
	private void LFINMEPQJBK(bool QOGNGJBOPEB)
	{
		if (!QOGNGJBOPEB)
		{
			this.JHKFJDEBNIH();
		}
	}

	// Token: 0x0400105D RID: 4189
	private long LNQKCPOHMGD = 10000000L;

	// Token: 0x0400105E RID: 4190
	private int CDJKHJOMGOG = 5100000;

	// Token: 0x0400105F RID: 4191
	private float OCBQBOIDNFF = 0.5f;

	// Token: 0x04001060 RID: 4192
	private float KPCNBELJPDF = 1f;

	// Token: 0x04001061 RID: 4193
	private byte MHKLNOHQPPM = 5;

	// Token: 0x04001062 RID: 4194
	private int PIBJNFCCPQG = 30;

	// Token: 0x04001063 RID: 4195
	private byte EKNOBQLGEBF;

	// Token: 0x04001064 RID: 4196
	private int CGNPIJFOJJK;

	// Token: 0x04001065 RID: 4197
	private long PEBFPGODLLK;

	// Token: 0x04001066 RID: 4198
	private long MNPHOCQPFDJ;

	// Token: 0x04001067 RID: 4199
	private long NEIJFPCCJMM;

	// Token: 0x04001068 RID: 4200
	private long FOLFQQEHHPL;

	// Token: 0x04001069 RID: 4201
	private float QJODIHHNOEB;

	// Token: 0x0400106A RID: 4202
	private bool DIJQQBKMOQN;
}
