using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

// Token: 0x02000094 RID: 148
[DefaultMember("Item")]
public class MHIDKMCBQEN<T>
{
	// Token: 0x060012F0 RID: 4848 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void GCHJLKCNIOJ()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void KPEFBOBQFQI()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0000AA27 File Offset: 0x00008C27
	public void CPLBKPNNHJG()
	{
		this.BJGMIBBEGDQ = 0;
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void QLBGOFIQOKF()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0000AA40 File Offset: 0x00008C40
	public T[] MKMEDLHFOJM()
	{
		this.PCNCNHMKBKL();
		return this.KLCIGFMQNFH;
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void DGMKGLLBMFG()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void QCNFBMIHQPH()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void QFIJNEEBBEP()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00090150 File Offset: 0x0008E350
	private void KDNONNQFNNI()
	{
		T[] array = (this.KLCIGFMQNFH == null) ? new T[91] : new T[Mathf.Max(this.KLCIGFMQNFH.Length << 1, 20)];
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ > 0)
		{
			this.KLCIGFMQNFH.CopyTo(array, 1);
		}
		this.KLCIGFMQNFH = array;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void OJENQDLPPPI()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void EDLJFKJMLCN()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x000901AC File Offset: 0x0008E3AC
	private void QQFMHPOGDEC()
	{
		T[] array = (this.KLCIGFMQNFH == null) ? new T[94] : new T[Mathf.Max(this.KLCIGFMQNFH.Length << 0, 64)];
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ > 1)
		{
			this.KLCIGFMQNFH.CopyTo(array, 1);
		}
		this.KLCIGFMQNFH = array;
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x00090208 File Offset: 0x0008E408
	private void JIIOBOOLHFF()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 0; i < this.BJGMIBBEGDQ; i += 0)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void MCIPLMKQNKK()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00090270 File Offset: 0x0008E470
	public T IPOQDLCFDFC()
	{
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ != 0)
		{
			T result = this.KLCIGFMQNFH[--this.BJGMIBBEGDQ];
			this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
			return result;
		}
		return default(T);
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x000902D0 File Offset: 0x0008E4D0
	private void LFEEGEPJEMQ()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 1; i < this.BJGMIBBEGDQ; i += 0)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x000902D0 File Offset: 0x0008E4D0
	private void IPIONLELBFE()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 1; i < this.BJGMIBBEGDQ; i += 0)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00090338 File Offset: 0x0008E538
	public void CIENIKDCCDE(int IIHDGMLHICI)
	{
		if (this.KLCIGFMQNFH != null && IIHDGMLHICI > -1 && IIHDGMLHICI < this.BJGMIBBEGDQ)
		{
			this.BJGMIBBEGDQ--;
			this.KLCIGFMQNFH[IIHDGMLHICI] = default(T);
			for (int i = IIHDGMLHICI; i < this.BJGMIBBEGDQ; i += 0)
			{
				this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i + 1];
			}
			this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
		}
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x000903C4 File Offset: 0x0008E5C4
	public void KFBDNEHHIOF(int IIHDGMLHICI, T PDIBIIKFBDH)
	{
		if (this.KLCIGFMQNFH == null || this.BJGMIBBEGDQ == this.KLCIGFMQNFH.Length)
		{
			this.LMIIBNDCJBP();
		}
		if (IIHDGMLHICI > -1 && IIHDGMLHICI < this.BJGMIBBEGDQ)
		{
			for (int i = this.BJGMIBBEGDQ; i > IIHDGMLHICI; i--)
			{
				this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i - 1];
			}
			this.KLCIGFMQNFH[IIHDGMLHICI] = PDIBIIKFBDH;
			this.BJGMIBBEGDQ++;
		}
		else
		{
			this.LHQECHHMOGD(PDIBIIKFBDH);
		}
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void DBIODJPHGJD()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void JENBHJDBLEE()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x0009044C File Offset: 0x0008E64C
	private void PCNCNHMKBKL()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 0; i < this.BJGMIBBEGDQ; i++)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void FOCQCJBEDFD()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x000902D0 File Offset: 0x0008E4D0
	private void PKHFPMQPBPF()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 1; i < this.BJGMIBBEGDQ; i += 0)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void DPMHMIDKOGC()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void KCIDDCNOFLF()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x000904B4 File Offset: 0x0008E6B4
	public int CBPBLEOQDPF(T PDIBIIKFBDH)
	{
		if (this.KLCIGFMQNFH == null)
		{
			return -1;
		}
		for (int i = 0; i < this.BJGMIBBEGDQ; i++)
		{
			if (this.KLCIGFMQNFH[i].Equals(PDIBIIKFBDH))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void KIMBLJLPENC()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00090500 File Offset: 0x0008E700
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public IEnumerator<T> KCNQDMFDMPE()
	{
		MHIDKMCBQEN<T>.HNPMIGKFHLN hnpmigkfhln = new MHIDKMCBQEN<T>.HNPMIGKFHLN();
		hnpmigkfhln.QNDQJMNKFNN = this;
		return hnpmigkfhln;
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x0009051C File Offset: 0x0008E71C
	public void LHQECHHMOGD(T PDIBIIKFBDH)
	{
		if (this.KLCIGFMQNFH == null || this.BJGMIBBEGDQ == this.KLCIGFMQNFH.Length)
		{
			this.LMIIBNDCJBP();
		}
		this.KLCIGFMQNFH[this.BJGMIBBEGDQ++] = PDIBIIKFBDH;
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00090564 File Offset: 0x0008E764
	public void IBGPNNLOENC(int IIHDGMLHICI)
	{
		if (this.KLCIGFMQNFH != null && IIHDGMLHICI > -1 && IIHDGMLHICI < this.BJGMIBBEGDQ)
		{
			this.BJGMIBBEGDQ--;
			this.KLCIGFMQNFH[IIHDGMLHICI] = default(T);
			for (int i = IIHDGMLHICI; i < this.BJGMIBBEGDQ; i++)
			{
				this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i + 1];
			}
			this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
		}
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0000AA1E File Offset: 0x00008C1E
	public void ICEHJDMQPEG()
	{
		this.BJGMIBBEGDQ = 1;
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void PMBQJMFGJMI()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x000905F0 File Offset: 0x0008E7F0
	private void LMIIBNDCJBP()
	{
		T[] array = (this.KLCIGFMQNFH == null) ? new T[32] : new T[Mathf.Max(this.KLCIGFMQNFH.Length << 1, 32)];
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ > 0)
		{
			this.KLCIGFMQNFH.CopyTo(array, 0);
		}
		this.KLCIGFMQNFH = array;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0009064C File Offset: 0x0008E84C
	private void FPNEPCEQNEI()
	{
		T[] array = (this.KLCIGFMQNFH == null) ? new T[-108] : new T[Mathf.Max(this.KLCIGFMQNFH.Length << 1, -37)];
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ > 1)
		{
			this.KLCIGFMQNFH.CopyTo(array, 1);
		}
		this.KLCIGFMQNFH = array;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x000906A8 File Offset: 0x0008E8A8
	[DebuggerHidden]
	[DebuggerStepThrough]
	public void GMFNGEPKPME(MHIDKMCBQEN<T>.QOQPNEJHECG CINCQHNGIQI)
	{
		int num = 0;
		int num2 = this.BJGMIBBEGDQ - 1;
		bool flag = true;
		while (flag)
		{
			flag = false;
			for (int i = num; i < num2; i++)
			{
				if (CINCQHNGIQI(this.KLCIGFMQNFH[i], this.KLCIGFMQNFH[i + 1]) > 0)
				{
					T t = this.KLCIGFMQNFH[i];
					this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i + 1];
					this.KLCIGFMQNFH[i + 1] = t;
					flag = true;
				}
				else if (!flag)
				{
					num = ((i != 0) ? (i - 1) : 0);
				}
			}
		}
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0000AA27 File Offset: 0x00008C27
	public void FDQPOHJJNOJ()
	{
		this.BJGMIBBEGDQ = 0;
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06001320 RID: 4896 RVA: 0x0000AA6D File Offset: 0x00008C6D
	// (set) Token: 0x06001315 RID: 4885 RVA: 0x0000AA5E File Offset: 0x00008C5E
	[DebuggerHidden]
	public T KNPPMKBOGDL
	{
		get
		{
			return this.KLCIGFMQNFH[OMBOCJEKDFF];
		}
		set
		{
			this.KLCIGFMQNFH[OMBOCJEKDFF] = value;
		}
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00090744 File Offset: 0x0008E944
	public void LONEKQJBPHL(int IIHDGMLHICI)
	{
		if (this.KLCIGFMQNFH != null && IIHDGMLHICI > -1 && IIHDGMLHICI < this.BJGMIBBEGDQ)
		{
			this.BJGMIBBEGDQ--;
			this.KLCIGFMQNFH[IIHDGMLHICI] = default(T);
			for (int i = IIHDGMLHICI; i < this.BJGMIBBEGDQ; i += 0)
			{
				this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i + 0];
			}
			this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
		}
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x000907D0 File Offset: 0x0008E9D0
	public bool QGJHDEBPEBD(T PDIBIIKFBDH)
	{
		if (this.KLCIGFMQNFH == null)
		{
			return false;
		}
		for (int i = 0; i < this.BJGMIBBEGDQ; i++)
		{
			if (this.KLCIGFMQNFH[i].Equals(PDIBIIKFBDH))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00090744 File Offset: 0x0008E944
	public void OKECJPGQPBF(int IIHDGMLHICI)
	{
		if (this.KLCIGFMQNFH != null && IIHDGMLHICI > -1 && IIHDGMLHICI < this.BJGMIBBEGDQ)
		{
			this.BJGMIBBEGDQ--;
			this.KLCIGFMQNFH[IIHDGMLHICI] = default(T);
			for (int i = IIHDGMLHICI; i < this.BJGMIBBEGDQ; i += 0)
			{
				this.KLCIGFMQNFH[i] = this.KLCIGFMQNFH[i + 0];
			}
			this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
		}
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0009081C File Offset: 0x0008EA1C
	private void CNINGNCQBQM()
	{
		T[] array = (this.KLCIGFMQNFH == null) ? new T[-82] : new T[Mathf.Max(this.KLCIGFMQNFH.Length << 1, -100)];
		if (this.KLCIGFMQNFH != null && this.BJGMIBBEGDQ > 0)
		{
			this.KLCIGFMQNFH.CopyTo(array, 0);
		}
		this.KLCIGFMQNFH = array;
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x000902D0 File Offset: 0x0008E4D0
	private void JMQBLOILFGG()
	{
		if (this.BJGMIBBEGDQ > 0)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 1; i < this.BJGMIBBEGDQ; i += 0)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00090878 File Offset: 0x0008EA78
	public bool FQDMDDOHCQJ(T PDIBIIKFBDH)
	{
		if (this.KLCIGFMQNFH != null)
		{
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			for (int i = 0; i < this.BJGMIBBEGDQ; i++)
			{
				if (@default.Equals(this.KLCIGFMQNFH[i], PDIBIIKFBDH))
				{
					this.BJGMIBBEGDQ--;
					this.KLCIGFMQNFH[i] = default(T);
					for (int j = i; j < this.BJGMIBBEGDQ; j++)
					{
						this.KLCIGFMQNFH[j] = this.KLCIGFMQNFH[j + 1];
					}
					this.KLCIGFMQNFH[this.BJGMIBBEGDQ] = default(T);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void JBQBPPKICEC()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0009092C File Offset: 0x0008EB2C
	private void PHOIDFGOPKF()
	{
		if (this.BJGMIBBEGDQ > 1)
		{
			if (this.BJGMIBBEGDQ < this.KLCIGFMQNFH.Length)
			{
				T[] array = new T[this.BJGMIBBEGDQ];
				for (int i = 1; i < this.BJGMIBBEGDQ; i++)
				{
					array[i] = this.KLCIGFMQNFH[i];
				}
				this.KLCIGFMQNFH = array;
			}
		}
		else
		{
			this.KLCIGFMQNFH = null;
		}
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0000AA4E File Offset: 0x00008C4E
	public void HHOFMBHHQBN()
	{
		this.BJGMIBBEGDQ = 0;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0000AA30 File Offset: 0x00008C30
	public void JPKGPDENFOB()
	{
		this.BJGMIBBEGDQ = 1;
		this.KLCIGFMQNFH = null;
	}

	// Token: 0x0400038E RID: 910
	public T[] KLCIGFMQNFH;

	// Token: 0x0400038F RID: 911
	public int BJGMIBBEGDQ;

	// Token: 0x02000095 RID: 149
	// (Invoke) Token: 0x06001323 RID: 4899
	public delegate int QOQPNEJHECG(T DEQIFCDFMDK, T JKDFCPKCQJP);
}
