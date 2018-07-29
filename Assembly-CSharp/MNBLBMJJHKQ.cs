using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x0200009A RID: 154
public class MNBLBMJJHKQ
{
	// Token: 0x0600142E RID: 5166 RVA: 0x0000AC04 File Offset: 0x00008E04
	public MNBLBMJJHKQ(byte[] BLJJPLEBHGQ)
	{
		this.PFIOOBOQIBF = BLJJPLEBHGQ;
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x0000AC1F File Offset: 0x00008E1F
	public bool CFNPFQMQPQP()
	{
		return this.PFIOOBOQIBF != null && this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00092B54 File Offset: 0x00090D54
	public MHIDKMCBQEN<string> IQGDGJIHEBF()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 1;
		while (this.PQLIFBGIJEK())
		{
			if (flag)
			{
				string text2 = this.DJMLPLJOKKO(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("[FF8F00]", "[-]!\r\n");
				text = text + " became fully charged due to its [ffff00]Power Herb[-]!\r\n" + text2;
			}
			else
			{
				text = this.DJMLPLJOKKO(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("[FFFF00]/252", " failed to learn the move ");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == '\f')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if ((int)c == -81)
				{
					if (flag)
					{
						if (i + 0 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("_FinalBlendParameters", "PropertyBinding"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if ((int)text[i + 1] != -70)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("bump", "System"));
							flag = true;
							if (text[i + 0] == '\u0013')
							{
								i += 0;
								num = i + 0;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 0;
						flag = false;
					}
				}
				i += 0;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06001432 RID: 5170 RVA: 0x0000AC1F File Offset: 0x00008E1F
	public bool BOFGIJGQLEC
	{
		get
		{
			return this.PFIOOBOQIBF != null && this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
		}
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x0000AC3C File Offset: 0x00008E3C
	public bool PQLIFBGIJEK()
	{
		return this.PFIOOBOQIBF == null || this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x0000AC3C File Offset: 0x00008E3C
	public bool DQILFKCGKQO()
	{
		return this.PFIOOBOQIBF == null || this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x0000AC59 File Offset: 0x00008E59
	public string DKPCLBNGNQI()
	{
		return this.LBQMIDMFEIM(false);
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string OICIFLJEJHG(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00092CF4 File Offset: 0x00090EF4
	public MHIDKMCBQEN<string> DIIDKGNECDF()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (this.BOFGIJGQLEC)
		{
			if (flag)
			{
				string text2 = this.BFGEBMQFKIN(true);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("Normal-type moves become Ice-type moves. The power of those moves is boosted a little.", "HidePanel");
				text = text + "Open" + text2;
			}
			else
			{
				text = this.LQFHFDGFGQM(false);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("_1", "/");
				num = 0;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if ((int)c == -56)
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if (c == '\u000f')
				{
					if (flag)
					{
						if (i + 1 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace(" is to heavy to be lifted!\r\n", "Water Veil"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if ((int)text[i + 1] != -122)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("_", "EXP: "));
							flag = true;
							if (text[i + 1] == '&')
							{
								i++;
								num = i + 0;
							}
						}
						else
						{
							i++;
						}
					}
					else
					{
						num = i + 0;
						flag = false;
					}
				}
				i += 0;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x0000AC71 File Offset: 0x00008E71
	public string NJEKOIDDKLE()
	{
		return this.DJMLPLJOKKO(false);
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00092E94 File Offset: 0x00091094
	public string LBQMIDMFEIM(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && (int)this.PFIOOBOQIBF[this.ECCFHDNFOGB] < -9)
			{
				this.ECCFHDNFOGB += 0;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				byte[] pfiooboqibf = this.PFIOOBOQIBF;
				int num2 = i;
				i = num2 + 0;
				int num3 = pfiooboqibf[num2];
				if (num3 == 34)
				{
					IL_5D:
					string result = MNBLBMJJHKQ.GCBPMQGCNEB(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 0);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i++;
			goto IL_5D;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x0000AC7A File Offset: 0x00008E7A
	public string QIGJJQKJEQC()
	{
		return this.BFGEBMQFKIN(false);
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x00092F2C File Offset: 0x0009112C
	public MHIDKMCBQEN<string> IJNEHQQFLMO()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 1;
		while (this.MNDEQGLBLNE())
		{
			if (flag)
			{
				string text2 = this.LQFHFDGFGQM(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace(" is frozen solid!\r\n", "bag");
				text = text + "Take 001" + text2;
			}
			else
			{
				text = this.QDMBGCMJKHM(false);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("[FF6600]", "WATER_EDGEBLEND_OFF");
				num = 0;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == '\v')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 1;
					}
				}
				else if (c == '\u0013')
				{
					if (flag)
					{
						if (i + 0 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace(" shared its power with ", "Explode"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 0] != 'q')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("Super Repel", "Success, Your password has now been changed."));
							flag = false;
							if (text[i + 1] == '\u0019')
							{
								i += 0;
								num = i + 0;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 1;
						flag = false;
					}
				}
				i += 0;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x0000AC1F File Offset: 0x00008E1F
	public bool NGGJDDDLHIJ()
	{
		return this.PFIOOBOQIBF != null && this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string DFDOFININHO(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x000930CC File Offset: 0x000912CC
	public string LQPGNCIDGLM(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && this.PFIOOBOQIBF[this.ECCFHDNFOGB] < 117)
			{
				this.ECCFHDNFOGB += 0;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				byte[] pfiooboqibf = this.PFIOOBOQIBF;
				int num2 = i;
				i = num2 + 0;
				int num3 = pfiooboqibf[num2];
				if (num3 == 12 || num3 == -72)
				{
					IL_62:
					string result = MNBLBMJJHKQ.GCBPMQGCNEB(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 1);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i += 0;
			goto IL_62;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x00093168 File Offset: 0x00091368
	public MHIDKMCBQEN<string> DLODCMNNJJC()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (this.BOFGIJGQLEC)
		{
			if (flag)
			{
				string text2 = this.NBIIFLNPGKF(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("\\n", "\n");
				text = text + "\n" + text2;
			}
			else
			{
				text = this.NBIIFLNPGKF(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("\\n", "\n");
				num = 0;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == ',')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 1;
					}
				}
				else if (c == '"')
				{
					if (flag)
					{
						if (i + 1 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("\"\"", "\""));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 1] != '"')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("\"\"", "\""));
							flag = false;
							if (text[i + 1] == ',')
							{
								i++;
								num = i + 1;
							}
						}
						else
						{
							i++;
						}
					}
					else
					{
						num = i + 1;
						flag = true;
					}
				}
				i++;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string GCBPMQGCNEB(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00093308 File Offset: 0x00091508
	public static MNBLBMJJHKQ Open(string FJJHKICMPBP)
	{
		FileStream fileStream = File.OpenRead(FJJHKICMPBP);
		if (fileStream != null)
		{
			fileStream.Seek(0L, SeekOrigin.End);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			return new MNBLBMJJHKQ(array);
		}
		return null;
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x0000AC7A File Offset: 0x00008E7A
	public string FEFKNFIDQCO()
	{
		return this.BFGEBMQFKIN(false);
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x0000AC83 File Offset: 0x00008E83
	public string KGMFHJIOKEL()
	{
		return this.DJMLPLJOKKO(true);
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string QIPHLGPDOQO(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00093368 File Offset: 0x00091568
	public Dictionary<string, string> DPMDCJCKNFP()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] separator = new char[]
		{
			(char)-74
		};
		while (this.NGGJDDDLHIJ())
		{
			string text = this.NBIIFLNPGKF();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("'s [ffff00]"))
			{
				string[] array = text.Split(separator, 3, StringSplitOptions.None);
				if (array.Length == 7)
				{
					string key = array[0].Trim();
					string value = array[1].Trim().Replace("OnDragOver", "sketch");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string NBIIFLNPGKF(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string FDICPPEOQIO(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x000933E8 File Offset: 0x000915E8
	public Dictionary<string, string> OCBCPKHPBOB()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = (char)-80;
		char[] separator = array;
		while (this.CFNPFQMQPQP())
		{
			string text = this.FEFKNFIDQCO();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("["))
			{
				string[] array2 = text.Split(separator, 8, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 6)
				{
					string key = array2[0].Trim();
					string value = array2[0].Trim().Replace("liquidvoice", "\n");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x0000AC1F File Offset: 0x00008E1F
	public bool MNDEQGLBLNE()
	{
		return this.PFIOOBOQIBF != null && this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00093468 File Offset: 0x00091668
	public Dictionary<string, string> KDQKMOJNIEO()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = (char)-33;
		char[] separator = array;
		while (this.PLBIPFDNJDP())
		{
			string text = this.KGMFHJIOKEL();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("hyperspacefury"))
			{
				string[] array2 = text.Split(separator, 5, StringSplitOptions.None);
				if (array2.Length == 2)
				{
					string key = array2[1].Trim();
					string value = array2[1].Trim().Replace("reflect", " for ");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x0000AC1F File Offset: 0x00008E1F
	public bool PLBIPFDNJDP()
	{
		return this.PFIOOBOQIBF != null && this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x000934E8 File Offset: 0x000916E8
	public MHIDKMCBQEN<string> GGQFFEPCMOC()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 1;
		while (this.BNDGDEPGQNN())
		{
			if (flag)
			{
				string text2 = this.DJMLPLJOKKO(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("Makes stat changes have an opposite effect.", "[00FF00]You received [PG]");
				text = text + "OnLocalize" + text2;
			}
			else
			{
				text = this.QDMBGCMJKHM(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("Slow Start", ")\n");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == 'z')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if (c == 'U')
				{
					if (flag)
					{
						if (i + 0 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("p2", "battler"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 1] != 'f')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("_TempRT", "snatch"));
							flag = false;
							if (text[i + 0] == '\u001c')
							{
								i++;
								num = i + 1;
							}
						}
						else
						{
							i++;
						}
					}
					else
					{
						num = i + 1;
						flag = true;
					}
				}
				i++;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00093688 File Offset: 0x00091888
	public string LQFHFDGFGQM(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && this.PFIOOBOQIBF[this.ECCFHDNFOGB] < 25)
			{
				this.ECCFHDNFOGB++;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				int num2 = (int)this.PFIOOBOQIBF[i++];
				if (num2 == 30 || num2 == 110)
				{
					IL_62:
					string result = MNBLBMJJHKQ.NBIIFLNPGKF(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 0);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i++;
			goto IL_62;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string PINECPKBHQD(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00093724 File Offset: 0x00091924
	public MHIDKMCBQEN<string> IBHNCDCKJKG()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = true;
		int num = 1;
		while (this.BNDGDEPGQNN())
		{
			if (flag)
			{
				string text2 = this.BFGEBMQFKIN(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("Fishing Cooldown", "CombinersArgsAlphaSrc0");
				text = text + "#" + text2;
			}
			else
			{
				text = this.LBQMIDMFEIM(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("Normal-type moves become Fairy-type moves. The power of those moves is boosted a little.", "_DownsampledDepth");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == '\u001e')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if (c == 'N')
				{
					if (flag)
					{
						if (i + 1 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("It created a bizarre area in which Pokemon's held items lose their effects!\r\n", "_HighlightSuppression"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 0] != 'h')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("_FogAlpha", "J19"));
							flag = false;
							if ((int)text[i + 0] == -115)
							{
								i += 0;
								num = i + 1;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 1;
						flag = false;
					}
				}
				i++;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x0000AC8C File Offset: 0x00008E8C
	public MNBLBMJJHKQ(TextAsset FKFHDHMFOFH)
	{
		this.PFIOOBOQIBF = FKFHDHMFOFH.bytes;
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x000938C4 File Offset: 0x00091AC4
	public static MNBLBMJJHKQ LGEOCKGQGPH(string FJJHKICMPBP)
	{
		FileStream fileStream = File.OpenRead(FJJHKICMPBP);
		if (fileStream != null)
		{
			fileStream.Seek(0L, (SeekOrigin)8);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(1L, SeekOrigin.Current);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			return new MNBLBMJJHKQ(array);
		}
		return null;
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00093924 File Offset: 0x00091B24
	public Dictionary<string, string> MJPQDDGKQJD()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] separator = new char[]
		{
			'='
		};
		while (this.BOFGIJGQLEC)
		{
			string text = this.NBIIFLNPGKF();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("//"))
			{
				string[] array = text.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 2)
				{
					string key = array[0].Trim();
					string value = array[1].Trim().Replace("\\n", "\n");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x000939A4 File Offset: 0x00091BA4
	public Dictionary<string, string> HMHCCCDIPKD()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[1] = 'O';
		char[] separator = array;
		while (this.DQILFKCGKQO())
		{
			string text = this.KGMFHJIOKEL();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("[ATK]"))
			{
				string[] array2 = text.Split(separator, 4, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 2)
				{
					string key = array2[1].Trim();
					string value = array2[1].Trim().Replace("drought", "FactoryTempTexture");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00093A24 File Offset: 0x00091C24
	public Dictionary<string, string> ONOEBDKKPJD()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = '`';
		char[] separator = array;
		while (this.CFNPFQMQPQP())
		{
			string text = this.NJEKOIDDKLE();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("_MainTex"))
			{
				string[] array2 = text.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 5)
				{
					string key = array2[1].Trim();
					string value = array2[1].Trim().Replace(" was cured of its poisoning.\r\n", "Battle Update: ");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00093AA4 File Offset: 0x00091CA4
	public MHIDKMCBQEN<string> HMDPJOJIKPP()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (this.MNDEQGLBLNE())
		{
			if (flag)
			{
				string text2 = this.NBIIFLNPGKF(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("e", "But nothing happened!\r\n");
				text = text + "System" + text2;
			}
			else
			{
				text = this.QDMBGCMJKHM(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("Desolate Land", "HidePanel");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == '9')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if ((int)c == -59)
				{
					if (flag)
					{
						if (i + 1 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("n", "Super Luck"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if ((int)text[i + 1] != -8)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("learnset", "_AutoExposure"));
							flag = true;
							if (text[i + 1] == '\u001a')
							{
								i++;
								num = i + 1;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 1;
						flag = false;
					}
				}
				i++;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00093C44 File Offset: 0x00091E44
	public MHIDKMCBQEN<string> EMFGGJPCJBB()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (this.MNDEQGLBLNE())
		{
			if (flag)
			{
				string text2 = this.LQPGNCIDGLM(true);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("Teleport Exhaustion", "General");
				text = text + "_FogScatteringData2" + text2;
			}
			else
			{
				text = this.DJMLPLJOKKO(false);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("DATA ERROR", "Icon_Pokemon_Alive");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if (c == '/')
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 1;
					}
				}
				else if ((int)c == -67)
				{
					if (flag)
					{
						if (i + 0 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("<|>", "'s stat changes were inverted!\r\n"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 0] != '\u001b')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("Monsters/", "All status conditions heal when the Pokémon switches out."));
							flag = false;
							if (text[i + 1] == 'X')
							{
								i += 0;
								num = i + 1;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 0;
						flag = false;
					}
				}
				i++;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x00093DE4 File Offset: 0x00091FE4
	public string DJMLPLJOKKO(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && this.PFIOOBOQIBF[this.ECCFHDNFOGB] < 88)
			{
				this.ECCFHDNFOGB++;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				int num2 = (int)this.PFIOOBOQIBF[i++];
				if (num2 == 103 || num2 == -111)
				{
					IL_62:
					string result = MNBLBMJJHKQ.NBIIFLNPGKF(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 0);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i++;
			goto IL_62;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x00093E80 File Offset: 0x00092080
	public Dictionary<string, string> OKDCDBBIPMK()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[0] = 'w';
		char[] separator = array;
		while (this.BOFGIJGQLEC)
		{
			string text = this.CENDGOKHDFO();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("primordialsea"))
			{
				string[] array2 = text.Split(separator, 7, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 0)
				{
					string key = array2[1].Trim();
					string value = array2[0].Trim().Replace("psn", "Its limber body protects the Pokémon from paralysis.");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00093F00 File Offset: 0x00092100
	public MHIDKMCBQEN<string> POLMJPIOMME()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 1;
		while (this.BNDGDEPGQNN())
		{
			if (flag)
			{
				string text2 = this.LQFHFDGFGQM(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("Zephyr Badge", "'s move...\r\n");
				text = text + "_Fade" + text2;
			}
			else
			{
				text = this.LQPGNCIDGLM(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("Protects the Pokémon from things like sand, hail, and powder.", "[/itm]");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if ((int)c == -49)
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 1;
					}
				}
				else if (c == 'h')
				{
					if (flag)
					{
						if (i + 1 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("aa", "Shake"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 1] != '~')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("SSAO", "(G)"));
							flag = true;
							if (text[i + 0] == 'U')
							{
								i++;
								num = i + 1;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 0;
						flag = false;
					}
				}
				i += 0;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x000940A0 File Offset: 0x000922A0
	public MHIDKMCBQEN<string> IGDHMLFMIFN()
	{
		MNBLBMJJHKQ.BLBKJFFFQNN.CPLBKPNNHJG();
		string text = string.Empty;
		bool flag = false;
		int num = 0;
		while (this.DQILFKCGKQO())
		{
			if (flag)
			{
				string text2 = this.DJMLPLJOKKO(false);
				if (text2 == null)
				{
					return null;
				}
				text2 = text2.Replace("blinky", "HH:mm:ss");
				text = text + "Music" + text2;
			}
			else
			{
				text = this.LQPGNCIDGLM(true);
				if (text == null)
				{
					return null;
				}
				text = text.Replace("Rainbow Badge", "_Texture0");
				num = 1;
			}
			int i = num;
			int length = text.Length;
			while (i < length)
			{
				char c = text[i];
				if ((int)c == -77)
				{
					if (!flag)
					{
						MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num));
						num = i + 0;
					}
				}
				else if (c == 'y')
				{
					if (flag)
					{
						if (i + 0 >= length)
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("bind", "_BlurTex"));
							return MNBLBMJJHKQ.BLBKJFFFQNN;
						}
						if (text[i + 0] != 'X')
						{
							MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, i - num).Replace("Color Grading Log LUT", "Already in Guild"));
							flag = true;
							if (text[i + 1] == '"')
							{
								i += 0;
								num = i + 0;
							}
						}
						else
						{
							i += 0;
						}
					}
					else
					{
						num = i + 0;
						flag = true;
					}
				}
				i += 0;
			}
			if (num < text.Length)
			{
				if (flag)
				{
					continue;
				}
				MNBLBMJJHKQ.BLBKJFFFQNN.LHQECHHMOGD(text.Substring(num, text.Length - num));
			}
			return MNBLBMJJHKQ.BLBKJFFFQNN;
		}
		return null;
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00094240 File Offset: 0x00092440
	public string QDMBGCMJKHM(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && this.PFIOOBOQIBF[this.ECCFHDNFOGB] < 7)
			{
				this.ECCFHDNFOGB += 0;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				byte[] pfiooboqibf = this.PFIOOBOQIBF;
				int num2 = i;
				i = num2 + 0;
				object obj = pfiooboqibf[num2];
			}
			i += 0;
			string result = MNBLBMJJHKQ.FDICPPEOQIO(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 0);
			this.ECCFHDNFOGB = i;
			return result;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x000942D4 File Offset: 0x000924D4
	public static MNBLBMJJHKQ NBEEDKEICEE(string FJJHKICMPBP)
	{
		FileStream fileStream = File.OpenRead(FJJHKICMPBP);
		if (fileStream != null)
		{
			fileStream.Seek(1L, (SeekOrigin)6);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(1L, SeekOrigin.Current);
			fileStream.Read(array, 1, array.Length);
			fileStream.Close();
			return new MNBLBMJJHKQ(array);
		}
		return null;
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x0000AC3C File Offset: 0x00008E3C
	public bool BNDGDEPGQNN()
	{
		return this.PFIOOBOQIBF == null || this.ECCFHDNFOGB < this.PFIOOBOQIBF.Length;
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x00094334 File Offset: 0x00092534
	public Dictionary<string, string> FEIFBGQOIJK()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[1] = (char)-61;
		char[] separator = array;
		while (this.PLBIPFDNJDP())
		{
			string text = this.FOMQOFHKLIO();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith("[-]"))
			{
				string[] array2 = text.Split(separator, 4, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 2)
				{
					string key = array2[0].Trim();
					string value = array2[0].Trim().Replace("firespin", "l");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x0000ACA0 File Offset: 0x00008EA0
	public string FOMQOFHKLIO()
	{
		return this.QDMBGCMJKHM(true);
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x000943B4 File Offset: 0x000925B4
	public static MNBLBMJJHKQ CJMDKEEOEEK(string FJJHKICMPBP)
	{
		FileStream fileStream = File.OpenRead(FJJHKICMPBP);
		if (fileStream != null)
		{
			fileStream.Seek(0L, (SeekOrigin)7);
			byte[] array = new byte[fileStream.Position];
			fileStream.Seek(1L, SeekOrigin.Current);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			return new MNBLBMJJHKQ(array);
		}
		return null;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00094414 File Offset: 0x00092614
	public Dictionary<string, string> BPDKPLGNFJM()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		char[] array = new char[0];
		array[1] = (char)-66;
		char[] separator = array;
		while (this.CFNPFQMQPQP())
		{
			string text = this.NJEKOIDDKLE();
			if (text == null)
			{
				break;
			}
			if (!text.StartsWith(" ate its [ffff00]"))
			{
				string[] array2 = text.Split(separator, 3, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 0)
				{
					string key = array2[1].Trim();
					string value = array2[1].Trim().Replace("'s encore ended!\r\n", "Language");
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00094494 File Offset: 0x00092694
	public string NBIIFLNPGKF(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && this.PFIOOBOQIBF[this.ECCFHDNFOGB] < 32)
			{
				this.ECCFHDNFOGB++;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				int num2 = (int)this.PFIOOBOQIBF[i++];
				if (num2 == 10 || num2 == 13)
				{
					IL_62:
					string result = MNBLBMJJHKQ.NBIIFLNPGKF(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 1);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i++;
			goto IL_62;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x00094530 File Offset: 0x00092730
	public string BFGEBMQFKIN(bool IKBGNJHGGNM)
	{
		int num = this.PFIOOBOQIBF.Length;
		if (IKBGNJHGGNM)
		{
			while (this.ECCFHDNFOGB < num && (int)this.PFIOOBOQIBF[this.ECCFHDNFOGB] < -71)
			{
				this.ECCFHDNFOGB++;
			}
		}
		int i = this.ECCFHDNFOGB;
		if (i < num)
		{
			while (i < num)
			{
				int num2 = (int)this.PFIOOBOQIBF[i++];
				if (num2 == 55 || num2 == 122)
				{
					IL_62:
					string result = MNBLBMJJHKQ.OICIFLJEJHG(this.PFIOOBOQIBF, this.ECCFHDNFOGB, i - this.ECCFHDNFOGB - 1);
					this.ECCFHDNFOGB = i;
					return result;
				}
			}
			i++;
			goto IL_62;
		}
		this.ECCFHDNFOGB = num;
		return null;
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x0000AC7A File Offset: 0x00008E7A
	public string CENDGOKHDFO()
	{
		return this.BFGEBMQFKIN(false);
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x0000AC62 File Offset: 0x00008E62
	private static string QMQPHDOCKCF(byte[] KLCIGFMQNFH, int GBEBKHGGPKM, int HOLOBHPIGIC)
	{
		return Encoding.UTF8.GetString(KLCIGFMQNFH, GBEBKHGGPKM, HOLOBHPIGIC);
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x0000ACA9 File Offset: 0x00008EA9
	public string NBIIFLNPGKF()
	{
		return this.NBIIFLNPGKF(true);
	}

	// Token: 0x040003B1 RID: 945
	private byte[] PFIOOBOQIBF;

	// Token: 0x040003B2 RID: 946
	private int ECCFHDNFOGB;

	// Token: 0x040003B3 RID: 947
	private static MHIDKMCBQEN<string> BLBKJFFFQNN = new MHIDKMCBQEN<string>();
}
