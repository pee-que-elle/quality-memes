using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000109 RID: 265
[AddComponentMenu("NGUI/UI/Input Field")]
public class JIMBBPLINGI : MonoBehaviour
{
	// Token: 0x06001DFE RID: 7678 RVA: 0x000C6058 File Offset: 0x000C4258
	private void OBINKJLMDHQ(KeyCode LOHECPFGPGO)
	{
		int frameCount = Time.frameCount;
		if (JIMBBPLINGI.HGODEHOPKEC == frameCount)
		{
			return;
		}
		if (this.OJIDBLEKBBO != null && (LOHECPFGPGO == this.OJIDBLEKBBO.EFOIHGJCNIE || LOHECPFGPGO == this.OJIDBLEKBBO.QIBCQINDBPN))
		{
			JIMBBPLINGI.HGODEHOPKEC = frameCount;
			this.GKHHCNCGLCD = true;
		}
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x0001073C File Offset: 0x0000E93C
	public string BBMLGDCJLDP()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOPNHMBPKHF();
		}
		return this.MGNEEDBHLOJ;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00010752 File Offset: 0x0000E952
	public void JLNKMINCMNF(int BGBMIEJJQKC)
	{
		if (this.IPKONCFDGFN())
		{
			this.PMIKHLEBIFH = BGBMIEJJQKC;
			this.HGJBNMJBJDQ();
		}
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000C60AC File Offset: 0x000C42AC
	protected char GEODEQDOMIP(string PIDLOFMIEFQ, int NKKGPNPGDEM, char BFBMOIKCELJ)
	{
		if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None && base.enabled)
		{
			if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Integer)
			{
				if (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == '-' && NKKGPNPGDEM == 0 && !PIDLOFMIEFQ.Contains("-"))
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Hex)
			{
				if (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'f')
				{
					return BFBMOIKCELJ - 'a' + 'A';
				}
				if (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'F')
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Float)
			{
				if (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == '-' && NKKGPNPGDEM == 0 && !PIDLOFMIEFQ.Contains("-"))
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == '.' && !PIDLOFMIEFQ.Contains("."))
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Alphanumeric)
			{
				if (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'Z')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'z')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9')
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Username)
			{
				if (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'Z')
				{
					return BFBMOIKCELJ - 'A' + 'a';
				}
				if (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'z')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9')
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Filename)
			{
				if (BFBMOIKCELJ == ':')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '/')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '\\')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '<')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '>')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '|')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '^')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '*')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == ';')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '"')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '`')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '\t')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '\n')
				{
					return '\0';
				}
				return BFBMOIKCELJ;
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Name)
			{
				char c = (PIDLOFMIEFQ.Length <= 0) ? ' ' : PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM, 0, PIDLOFMIEFQ.Length - 1)];
				char c2 = (PIDLOFMIEFQ.Length <= 0) ? '\n' : PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM + 1, 0, PIDLOFMIEFQ.Length - 1)];
				if (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'z')
				{
					if (c == ' ')
					{
						return BFBMOIKCELJ - 'a' + 'A';
					}
					return BFBMOIKCELJ;
				}
				else if (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'Z')
				{
					if (c != ' ' && c != '\'')
					{
						return BFBMOIKCELJ - 'A' + 'a';
					}
					return BFBMOIKCELJ;
				}
				else if (BFBMOIKCELJ == '\'')
				{
					if (c != ' ' && c != '\'' && c2 != '\'' && !PIDLOFMIEFQ.Contains("'"))
					{
						return BFBMOIKCELJ;
					}
				}
				else if (BFBMOIKCELJ == ' ' && c != ' ' && c != '\'' && c2 != ' ' && c2 != '\'')
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.GuildName)
			{
				char c3 = (PIDLOFMIEFQ.Length <= 0) ? ' ' : PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM, 0, PIDLOFMIEFQ.Length - 1)];
				char c4 = (PIDLOFMIEFQ.Length <= 0) ? '\n' : PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM + 1, 0, PIDLOFMIEFQ.Length - 1)];
				if (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'z')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'Z')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == ' ' && c3 != ' ' && c3 != '\'' && c4 != ' ' && c4 != '\'')
				{
					return BFBMOIKCELJ;
				}
			}
			return '\0';
		}
		return BFBMOIKCELJ;
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00010769 File Offset: 0x0000E969
	protected virtual void OnDrag(Vector2 JDOGIQGGLKM)
	{
		if (this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch))
		{
			this.BQIMBNNFJEO = this.CKQJNMDJMCG();
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x000C63C4 File Offset: 0x000C45C4
	public virtual bool MBCDEIONDON(Event BENEPFFKJQQ)
	{
		if (this.KEQMEGEHFIK == null)
		{
			return false;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = (platform != RuntimePlatform.OSXEditor && platform != RuntimePlatform.OSXPlayer) ? ((BENEPFFKJQQ.modifiers & EventModifiers.Control) != EventModifiers.None) : ((BENEPFFKJQQ.modifiers & EventModifiers.Command) != EventModifiers.None);
		if ((BENEPFFKJQQ.modifiers & EventModifiers.Alt) != EventModifiers.None)
		{
			flag = false;
		}
		bool flag2 = (BENEPFFKJQQ.modifiers & EventModifiers.Shift) != EventModifiers.None;
		KeyCode keyCode = BENEPFFKJQQ.keyCode;
		switch (keyCode)
		{
		case KeyCode.UpArrow:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.UpArrow, string.Empty);
				if (this.PMIKHLEBIFH != 0)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.DownArrow:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.DownArrow, string.Empty);
				if (this.PMIKHLEBIFH != this.KEQMEGEHFIK.NKKFKOQQGDE.Length)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.RightArrow:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				int pmikhlebifh = this.PMIKHLEBIFH;
				this.PMIKHLEBIFH = Mathf.Min(this.PMIKHLEBIFH + 1, this.mValue.Length);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.BKQLIEQMHOF(pmikhlebifh);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.LeftArrow:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = Mathf.Max(this.PMIKHLEBIFH - 1, 0);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.LCGOMKJIKHC(this.PMIKHLEBIFH);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.Home:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.QJJLOHHFQNC)
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.Home, string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = 0;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.End:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.QJJLOHHFQNC)
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.End, string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.PageUp:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = 0;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.PageDown:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.mValue.Length;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		}
		switch (keyCode)
		{
		case KeyCode.A:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.HMHBPLHCIJO = 0;
				this.PMIKHLEBIFH = this.mValue.Length;
				this.KJPOHNEPJKI(0);
				this.PONHJCDKKEO();
			}
			return true;
		case KeyCode.C:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.OHILEILOIBJ();
			}
			return true;
		}
		switch (keyCode)
		{
		case KeyCode.V:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.KFBDNEHHIOF(IKBQNBHOJJB.LKOKCPHPDNF);
			}
			return true;
		case KeyCode.X:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.OHILEILOIBJ();
				this.KFBDNEHHIOF(string.Empty);
			}
			return true;
		}
		if (keyCode == KeyCode.Backspace)
		{
			BENEPFFKJQQ.Use();
			this.KEDBCCQLMON();
			return true;
		}
		if (keyCode != KeyCode.Delete)
		{
			return false;
		}
		BENEPFFKJQQ.Use();
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO >= this.mValue.Length)
				{
					return true;
				}
				this.PMIKHLEBIFH++;
			}
			if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.CNFPMNCBGKQ = array[0];
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[1];
						this.CNFPMNCBGKQ = array[0];
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
		return true;
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x000C68E8 File Offset: 0x000C4AE8
	protected string NOLFJQDMJJP()
	{
		int num = Mathf.Max(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
		return (string.IsNullOrEmpty(this.mValue) || num >= this.mValue.Length) ? string.Empty : this.mValue.Substring(num);
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x0001079B File Offset: 0x0000E99B
	public void CKENKDOMFEB(bool BGBMIEJJQKC)
	{
		this.GKHHCNCGLCD = BGBMIEJJQKC;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000107B0 File Offset: 0x0000E9B0
	public string OFLQCIBMFMH()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOBIQIDLQND();
		}
		return this.MGNEEDBHLOJ;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x000107C6 File Offset: 0x0000E9C6
	public bool MQIDDFQENPG()
	{
		return !this.DBJNMOKILIE || !(this.KEQMEGEHFIK != null) || this.KEQMEGEHFIK.FNDCJHHNOFL() || this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat;
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000107FA File Offset: 0x0000E9FA
	// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0001095A File Offset: 0x0000EB5A
	public bool GKHHCNCGLCD
	{
		get
		{
			return JIMBBPLINGI.PDDGJOQCIEQ == this;
		}
		set
		{
			if (!value)
			{
				if (this.GKHHCNCGLCD)
				{
					EMENMKHBPQE.CMPBKDMMHFQ = null;
				}
			}
			else
			{
				EMENMKHBPQE.CMPBKDMMHFQ = base.gameObject;
			}
		}
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000C6938 File Offset: 0x000C4B38
	private void GFLDQPEEJCG(int LBKMBCOOIHC = 0)
	{
		if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
		{
			int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(this.KQHHINEBEGJ() + LBKMBCOOIHC, this.HJMJDJKOILH());
			if (array == null)
			{
				array = this.KEQMEGEHFIK.QGCQQOHBILP(this.PMIKHLEBIFH + LBKMBCOOIHC, this.BGBMIEJJQKC);
				if (array != null)
				{
					if (this.PMIKHLEBIFH > array[0] - 3)
					{
						this.PMIKHLEBIFH = array[0];
					}
					else
					{
						this.PMIKHLEBIFH = array[1];
					}
					this.QCMHHCFDNEQ(this.PMIKHLEBIFH);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.CNFPMNCBGKQ + LBKMBCOOIHC, this.HJMJDJKOILH());
					if (array != null)
					{
						if (this.PMIKHLEBIFH > array[1] - 2)
						{
							this.PMIKHLEBIFH = array[0];
						}
						else
						{
							this.PMIKHLEBIFH = array[1];
						}
						this.KOIILJIKPIF(this.PMIKHLEBIFH);
					}
					else
					{
						array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH + LBKMBCOOIHC, this.HJMJDJKOILH());
						if (array != null)
						{
							if (this.PMIKHLEBIFH > array[1] - 2)
							{
								this.PMIKHLEBIFH = array[0];
							}
							else
							{
								this.PMIKHLEBIFH = array[1];
							}
							this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
						}
					}
				}
			}
			else
			{
				if (this.KQHHINEBEGJ() > array[1] - 6)
				{
					this.PMIKHLEBIFH = array[0];
				}
				else
				{
					this.PMIKHLEBIFH = array[0];
				}
				this.QCMHHCFDNEQ(this.PMIKHLEBIFH);
			}
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00010807 File Offset: 0x0000EA07
	// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0001079B File Offset: 0x0000E99B
	[Obsolete("Use UIInput.isSelected instead")]
	public bool EKGLJPNNDQL
	{
		get
		{
			return this.GKHHCNCGLCD;
		}
		set
		{
			this.GKHHCNCGLCD = value;
		}
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000C6A88 File Offset: 0x000C4C88
	protected int QHFNILQPNFH()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray ray = EMENMKHBPQE.OIJNBBFBBCQ();
		Plane plane = new Plane(pmcnqichcle[0], pmcnqichcle[0], pmcnqichcle[3]);
		float distance;
		return (!plane.Raycast(ray, out distance)) ? 0 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(ray.GetPoint(distance), true));
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000C6AFC File Offset: 0x000C4CFC
	protected int BNMMFIMPCDI()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray blhkbchjnqe = EMENMKHBPQE.BLHKBCHJNQE;
		Plane plane = new Plane(pmcnqichcle[0], pmcnqichcle[0], pmcnqichcle[4]);
		float distance;
		return (!plane.Raycast(blhkbchjnqe, out distance)) ? 1 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(blhkbchjnqe.GetPoint(distance), true));
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0001080F File Offset: 0x0000EA0F
	public void ELCIHMCEPQG(int BGBMIEJJQKC)
	{
		if (this.IPKONCFDGFN())
		{
			this.PMIKHLEBIFH = BGBMIEJJQKC;
			this.FCIIPHMMGHB();
		}
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x00010826 File Offset: 0x0000EA26
	public void CJQFKDOMIOD()
	{
		this.ELMDLDEKFIN(this.mValue);
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x00010834 File Offset: 0x0000EA34
	public Color ENLFPOQKNHQ()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOPNHMBPKHF();
		}
		return this.FJNHLJFLILF;
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000C6B70 File Offset: 0x000C4D70
	protected void CIPBCKKECIN()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 1)
				{
					return;
				}
				this.PMIKHLEBIFH -= 0;
			}
			if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)6)
			{
				int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(this.PMIKHLEBIFH, this.HJMJDJKOILH());
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.CNFPMNCBGKQ = array[0];
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[0];
						this.KOIILJIKPIF(array[1]);
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x0001084A File Offset: 0x0000EA4A
	public int MMMFEDJDMLQ()
	{
		return (!this.GKHHCNCGLCD) ? this.BGBMIEJJQKC.Length : this.PMIKHLEBIFH;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000C6C24 File Offset: 0x000C4E24
	public void MQFIIMHQGBK()
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			string text = this.mValue.Replace(" is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!", "[-]'s [ff6600]");
			this.mValue = string.Empty;
			this.NCBFKNGMKPB((!PlayerPrefs.HasKey(this.EDCMJKLMPKB)) ? text : PlayerPrefs.GetString(this.EDCMJKLMPKB));
		}
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000C6C80 File Offset: 0x000C4E80
	protected int FIIOHKNQOBB()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray blhkbchjnqe = EMENMKHBPQE.BLHKBCHJNQE;
		Plane plane = new Plane(pmcnqichcle[1], pmcnqichcle[0], pmcnqichcle[0]);
		float distance;
		return (!plane.Raycast(blhkbchjnqe, out distance)) ? 1 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(blhkbchjnqe.GetPoint(distance), false));
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x00010867 File Offset: 0x0000EA67
	protected void ELMDLDEKFIN(string QJFQOMOIOOI)
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			if (string.IsNullOrEmpty(QJFQOMOIOOI))
			{
				PlayerPrefs.DeleteKey(this.EDCMJKLMPKB);
			}
			else
			{
				PlayerPrefs.SetString(this.EDCMJKLMPKB, QJFQOMOIOOI);
			}
		}
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000C6CF4 File Offset: 0x000C4EF4
	protected virtual void NIDOLIOLKQF(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO && this.IPKONCFDGFN() && this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch))
		{
			this.BQIMBNNFJEO = this.ICDOKLFCNNM();
			if (!Input.GetKey((KeyCode)130) && !Input.GetKey((KeyCode)(-74)))
			{
				this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
			}
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000C6D60 File Offset: 0x000C4F60
	protected void OBEDJPGEODC()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOBIQIDLQND();
		}
		if (this.KEQMEGEHFIK != null)
		{
			this.KEQMEGEHFIK.OGGCMIKJGLD = this.PIKEJKDCMPH;
		}
		if (this.KEQMEGEHFIK != null && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.HJMJDJKOILH();
			if (string.IsNullOrEmpty(this.mValue))
			{
				this.KEQMEGEHFIK.LKPOBCBOFIC(this.MGNEEDBHLOJ);
				this.KEQMEGEHFIK.NONQDHBCIIN(this.FJNHLJFLILF);
			}
			else
			{
				this.KEQMEGEHFIK.PIDLOFMIEFQ = this.mValue;
			}
			Input.imeCompositionMode = IMECompositionMode.On;
			this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
		}
		JIMBBPLINGI.PDDGJOQCIEQ = null;
		this.PONHJCDKKEO();
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000C6E24 File Offset: 0x000C5024
	protected void IKGHBJBBEQN()
	{
		if (this.LPBPLMLMHBD)
		{
			this.CPCICJDOELQ();
		}
		if (this.KEQMEGEHFIK != null)
		{
			this.KEQMEGEHFIK.OGGCMIKJGLD = this.PIKEJKDCMPH;
		}
		if (this.KEQMEGEHFIK != null && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.HJMJDJKOILH();
			if (string.IsNullOrEmpty(this.mValue))
			{
				this.KEQMEGEHFIK.PIDLOFMIEFQ = this.MGNEEDBHLOJ;
				this.KEQMEGEHFIK.CEGFBBHMKOE = this.FJNHLJFLILF;
			}
			else
			{
				this.KEQMEGEHFIK.LKPOBCBOFIC(this.mValue);
			}
			Input.imeCompositionMode = IMECompositionMode.On;
			this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
		}
		JIMBBPLINGI.PDDGJOQCIEQ = null;
		this.EHIEIIPMCIP();
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x00010897 File Offset: 0x0000EA97
	public void KLLPLHHOLDD(int BGBMIEJJQKC)
	{
		if (this.FNQFOFODCPN())
		{
			this.PMIKHLEBIFH = BGBMIEJJQKC;
			this.OFHBJPDELLD();
		}
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x000C6EE8 File Offset: 0x000C50E8
	private void EENEDNQNLMJ(int GJCNQCEENLM)
	{
		if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)5)
		{
			int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(GJCNQCEENLM, this.BGBMIEJJQKC);
			if (array != null)
			{
				this.PMIKHLEBIFH = array[1];
				this.CNFPMNCBGKQ = array[1];
			}
			else
			{
				array = this.KEQMEGEHFIK.DCHHBENPMFF(GJCNQCEENLM, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.KOIILJIKPIF(array[0]);
				}
			}
		}
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x000C6F50 File Offset: 0x000C5150
	public void DHGEJKGNHCO()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		if (this.selectOnTab != null)
		{
			LMBPJGBGLNO lmbpjgbglno = base.GetComponent<LMBPJGBGLNO>();
			if (lmbpjgbglno == null)
			{
				lmbpjgbglno = base.gameObject.AddComponent<LMBPJGBGLNO>();
				lmbpjgbglno.IPQOIEDCMGH = this.selectOnTab;
			}
			this.selectOnTab = null;
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		if (this.PFQBOMINIHG && !string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			this.FMHHKCQBEQE();
		}
		else
		{
			this.NCBFKNGMKPB(this.mValue.Replace("move", "_WaveScale4"));
		}
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000108AE File Offset: 0x0000EAAE
	// (set) Token: 0x06001E5E RID: 7774 RVA: 0x00010B6B File Offset: 0x0000ED6B
	public Color IDEOONDHNEL
	{
		get
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			return this.FJNHLJFLILF;
		}
		set
		{
			this.FJNHLJFLILF = value;
			if (!this.GKHHCNCGLCD)
			{
				this.KEQMEGEHFIK.CEGFBBHMKOE = value;
			}
		}
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x00010826 File Offset: 0x0000EA26
	public void CQFMKOOEJNE()
	{
		this.ELMDLDEKFIN(this.mValue);
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x000108C4 File Offset: 0x0000EAC4
	public JLMPBLMOICG OBFKLCNNKJH()
	{
		return this.QCPLCODDHMG;
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000C6FE8 File Offset: 0x000C51E8
	protected void EOCFEGJIPKH()
	{
		this.KBIIICNECKK = Time.frameCount;
		JIMBBPLINGI.PDDGJOQCIEQ = this;
		if (this.LPBPLMLMHBD)
		{
			this.CPCICJDOELQ();
		}
		if (this.KEQMEGEHFIK != null)
		{
			this.PIKEJKDCMPH = this.KEQMEGEHFIK.OGGCMIKJGLD;
			this.KEQMEGEHFIK.OGGCMIKJGLD = false;
		}
		if (this.KEQMEGEHFIK != null && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LQEGJKMJNDF = Time.frameCount;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000108CC File Offset: 0x0000EACC
	// (set) Token: 0x06001E30 RID: 7728 RVA: 0x00010A17 File Offset: 0x0000EC17
	public string NJKPELHGLOD
	{
		get
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			return this.MGNEEDBHLOJ;
		}
		set
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			this.MGNEEDBHLOJ = value;
			this.PONHJCDKKEO();
		}
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000108E2 File Offset: 0x0000EAE2
	public void POPMOIOELBB()
	{
		this.GKHHCNCGLCD = false;
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00010B0A File Offset: 0x0000ED0A
	// (set) Token: 0x06001E22 RID: 7714 RVA: 0x000108EB File Offset: 0x0000EAEB
	public string BGBMIEJJQKC
	{
		get
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			return this.mValue;
		}
		set
		{
			this.PJMIKDIEGMB(value, true);
		}
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000108F5 File Offset: 0x0000EAF5
	protected virtual void JFHKGGNBKGL(Vector2 JDOGIQGGLKM)
	{
		if (this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch))
		{
			this.BQIMBNNFJEO = this.GGNOHFNCDCO();
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x000C7060 File Offset: 0x000C5260
	protected virtual void KDKLEBEMCLE(bool GKHHCNCGLCD)
	{
		if (GKHHCNCGLCD)
		{
			if (this.KEQMEGEHFIK != null)
			{
				this.KEQMEGEHFIK.IOCILKPHDHH = false;
			}
			if (this.IICMDBDMOIF == null)
			{
				this.IICMDBDMOIF = base.gameObject.AddComponent<CPFJGCCFHPN>();
			}
			this.EOCFEGJIPKH();
		}
		else
		{
			if (this.IICMDBDMOIF != null)
			{
				UnityEngine.Object.Destroy(this.IICMDBDMOIF);
				this.IICMDBDMOIF = null;
			}
			this.CBGPKDCGMQG();
			if (this.JDBFENKBQQL != null)
			{
				this.JDBFENKBQQL();
			}
		}
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x00010927 File Offset: 0x0000EB27
	protected void QQQJLNIQPGF()
	{
		if (JIMBBPLINGI.OMQCQCBLQGJ == null && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
		{
			JIMBBPLINGI.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
			JIMBBPLINGI.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x0001097A File Offset: 0x0000EB7A
	public void HOPMKPMDNIG(string BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x000C70EC File Offset: 0x000C52EC
	protected virtual void CLONODILHID()
	{
		if (this.QGNQJFCBJLG)
		{
			this.QGNQJFCBJLG.enabled = false;
		}
		if (this.QCPLCODDHMG)
		{
			this.QCPLCODDHMG.enabled = false;
		}
		if (this.COFIJEPKBLP)
		{
			IKBQNBHOJJB.MOPPIIOIIDM(this.COFIJEPKBLP);
			this.COFIJEPKBLP = null;
		}
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x000C714C File Offset: 0x000C534C
	public void OFHBJPDELLD()
	{
		if (this.KEQMEGEHFIK != null)
		{
			if (this.LPBPLMLMHBD)
			{
				this.IOBIQIDLQND();
			}
			bool flag = this.FNQFOFODCPN();
			string bgbmiejjqkc = this.BGBMIEJJQKC;
			bool flag2 = !string.IsNullOrEmpty(bgbmiejjqkc) || string.IsNullOrEmpty(Input.compositionString);
			this.KEQMEGEHFIK.NONQDHBCIIN((!flag2 || flag) ? this.MOKCQPEQHDF : this.FJNHLJFLILF);
			string text;
			if (flag2)
			{
				text = ((!flag) ? this.MGNEEDBHLOJ : string.Empty);
				this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
			}
			else
			{
				if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.Password)
				{
					text = string.Empty;
					string str = "A veil of water restored ";
					if (this.KEQMEGEHFIK.QBOJFLOEEGK() != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.ICJBMNQMGGD != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.ICJBMNQMGGD.OEQEJPEGKMF(-26) == null)
					{
						str = "Btn_TabHighlighted_Click";
					}
					int i = 1;
					int length = bgbmiejjqkc.Length;
					while (i < length)
					{
						text += str;
						i += 0;
					}
				}
				else
				{
					text = bgbmiejjqkc;
				}
				int num = (!flag) ? 0 : Mathf.Min(text.Length, this.NOIQOGBEKGI);
				string str2 = text.Substring(0, num);
				if (flag)
				{
					str2 += Input.compositionString;
				}
				text = str2 + text.Substring(num, text.Length - num);
				if (flag && this.KEQMEGEHFIK.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent && this.KEQMEGEHFIK.NGKMOMPQQPQ() == 1)
				{
					int num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text, true);
					if (num2 == 0)
					{
						JIMBBPLINGI.ECDMIMKCMLD = 1;
						this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
					}
					else if (num < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else if (num2 < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num2;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else
					{
						num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), false);
						if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)8 && num > 1)
						{
							int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(num - 0, text);
							if (array != null)
							{
								num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), false);
							}
							else
							{
								array = this.KEQMEGEHFIK.DCHHBENPMFF(num - 0, text);
								if (array != null)
								{
									num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
								}
							}
						}
						if (num2 > JIMBBPLINGI.ECDMIMKCMLD)
						{
							JIMBBPLINGI.ECDMIMKCMLD = num2;
							this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
						}
					}
					if (JIMBBPLINGI.ECDMIMKCMLD != 0 && JIMBBPLINGI.ECDMIMKCMLD != text.Length)
					{
						if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.AutoCorrect)
						{
							int[] array2 = this.KEQMEGEHFIK.KOMEFCQPPFG(JIMBBPLINGI.ECDMIMKCMLD, text);
							if (array2 != null)
							{
								int num3 = array2[1] + 43 - JIMBBPLINGI.ECDMIMKCMLD;
								if (num3 < 1 && JIMBBPLINGI.ECDMIMKCMLD > 0)
								{
									int num4 = array2[0] + 96;
									int num5 = array2[1] - num4;
									string text2 = this.HJMJDJKOILH().Substring(num4 - num3, num5 + num3);
									if (text2.Length <= 0)
									{
										text = text.Substring(array2[1]);
										JIMBBPLINGI.ECDMIMKCMLD = 1;
									}
									else
									{
										text = this.HJMJDJKOILH().Substring(array2[1], -55) + text2 + this.HJMJDJKOILH().Substring(array2[0], this.BGBMIEJJQKC.Length - array2[0]);
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(array2[0], 119) + text.Substring(array2[0] + 74, array2[0] - (array2[1] + -53) - 0) + text.Substring(array2[0] - 3, text.Length - (array2[0] - 3));
									JIMBBPLINGI.ECDMIMKCMLD = array2[1];
								}
							}
							else
							{
								array2 = this.KEQMEGEHFIK.DCHHBENPMFF(JIMBBPLINGI.ECDMIMKCMLD, text);
								if (array2 != null)
								{
									int num6 = array2[1] + -70 - JIMBBPLINGI.ECDMIMKCMLD;
									if (num6 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 1)
									{
										int num7 = array2[0] + 4;
										int num8 = array2[1] - num7;
										string text3 = this.BGBMIEJJQKC.Substring(num7 - num6, num8 + num6);
										if (text3.Length <= 6)
										{
											text = text.Substring(array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = 0;
										}
										else
										{
											text = this.BGBMIEJJQKC.Substring(array2[0], 110) + text3 + this.BGBMIEJJQKC.Substring(array2[0], this.BGBMIEJJQKC.Length - array2[0]);
											JIMBBPLINGI.ECDMIMKCMLD = array2[0];
										}
									}
									else
									{
										text = text.Substring(array2[1], 39) + text.Substring(array2[1] + 75, array2[1] - (array2[0] + 62) - 1) + text.Substring(array2[1] - 0, text.Length - (array2[1] - 5));
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
								}
							}
						}
						else
						{
							text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
						}
					}
				}
				else
				{
					JIMBBPLINGI.ECDMIMKCMLD = 1;
					this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
				}
			}
			this.KEQMEGEHFIK.LKPOBCBOFIC(text);
			if (flag)
			{
				int num9 = this.HMHBPLHCIJO - JIMBBPLINGI.ECDMIMKCMLD;
				int num10 = this.PMIKHLEBIFH - JIMBBPLINGI.ECDMIMKCMLD;
				if (num9 < 0)
				{
					num9 = 0;
				}
				if (num9 > text.Length)
				{
					num9 = text.Length;
				}
				if (num10 < 0)
				{
					num10 = 0;
				}
				if (num10 > text.Length)
				{
					num10 = text.Length;
				}
				if (this.COFIJEPKBLP == null)
				{
					this.COFIJEPKBLP = new Texture2D(0, 3, TextureFormat.ARGB32, false);
					for (int j = 0; j < 6; j++)
					{
						for (int k = 1; k < 4; k++)
						{
							this.COFIJEPKBLP.SetPixel(k, j, Color.white);
						}
					}
					this.COFIJEPKBLP.Apply();
				}
				if (num9 != num10)
				{
					if (this.QGNQJFCBJLG == null)
					{
						this.QGNQJFCBJLG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(13);
						this.QGNQJFCBJLG.name = "_Dissolve";
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.HPPHMEHKBHO = true;
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
					}
					else
					{
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.NPCECPIOPCB();
						this.QGNQJFCBJLG.enabled = false;
					}
				}
				if (this.QCPLCODDHMG == null)
				{
					this.QCPLCODDHMG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(-144);
					this.QCPLCODDHMG.name = ".";
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.HPPHMEHKBHO = false;
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
				}
				else
				{
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.NPCECPIOPCB();
					this.QCPLCODDHMG.enabled = true;
				}
				if (num9 != num10)
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, this.QGNQJFCBJLG.BPDNIHLBLOI, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					this.QGNQJFCBJLG.enabled = this.QGNQJFCBJLG.BPDNIHLBLOI.FGKMCGDPQOO();
				}
				else
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, null, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					if (this.QGNQJFCBJLG != null)
					{
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				this.HJQGNFEMOBG = JMIOBJFFGBN.ICIGHDPMDMP() + 430f;
				this.DPDJNDDDEID = this.KEQMEGEHFIK.NHCNEDEEONK;
			}
			else
			{
				this.CLONODILHID();
			}
		}
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x000C79AC File Offset: 0x000C5BAC
	public void FCIIPHMMGHB()
	{
		if (this.KEQMEGEHFIK != null)
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			bool flag = this.FNQFOFODCPN();
			string bgbmiejjqkc = this.BGBMIEJJQKC;
			bool flag2 = !string.IsNullOrEmpty(bgbmiejjqkc) || string.IsNullOrEmpty(Input.compositionString);
			this.KEQMEGEHFIK.NONQDHBCIIN((!flag2 || flag) ? this.MOKCQPEQHDF : this.FJNHLJFLILF);
			string text;
			if (flag2)
			{
				text = ((!flag) ? this.MGNEEDBHLOJ : string.Empty);
				this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
			}
			else
			{
				if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)5)
				{
					text = string.Empty;
					string str = "inky";
					if (this.KEQMEGEHFIK.QBOJFLOEEGK() != null && this.KEQMEGEHFIK.QBOJFLOEEGK().OKPOQOLHJGK() != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.OKPOQOLHJGK().OEQEJPEGKMF(-118) == null)
					{
						str = "[pok=";
					}
					int i = 1;
					int length = bgbmiejjqkc.Length;
					while (i < length)
					{
						text += str;
						i++;
					}
				}
				else
				{
					text = bgbmiejjqkc;
				}
				int num = (!flag) ? 1 : Mathf.Min(text.Length, this.NOIQOGBEKGI);
				string str2 = text.Substring(0, num);
				if (flag)
				{
					str2 += Input.compositionString;
				}
				text = str2 + text.Substring(num, text.Length - num);
				if (flag && this.KEQMEGEHFIK.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent && this.KEQMEGEHFIK.OFBGHIBHBLI == 1)
				{
					int num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text, false);
					if (num2 == 0)
					{
						JIMBBPLINGI.ECDMIMKCMLD = 0;
						this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
					}
					else if (num < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else if (num2 < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num2;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else
					{
						num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), false);
						if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)7 && num > 0)
						{
							int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(num - 0, text);
							if (array != null)
							{
								num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
							}
							else
							{
								array = this.KEQMEGEHFIK.DCHHBENPMFF(num - 1, text);
								if (array != null)
								{
									num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(1, num), true);
								}
							}
						}
						if (num2 > JIMBBPLINGI.ECDMIMKCMLD)
						{
							JIMBBPLINGI.ECDMIMKCMLD = num2;
							this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
						}
					}
					if (JIMBBPLINGI.ECDMIMKCMLD != 0 && JIMBBPLINGI.ECDMIMKCMLD != text.Length)
					{
						if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)4)
						{
							int[] array2 = this.KEQMEGEHFIK.QGCQQOHBILP(JIMBBPLINGI.ECDMIMKCMLD, text);
							if (array2 != null)
							{
								int num3 = array2[0] + -59 - JIMBBPLINGI.ECDMIMKCMLD;
								if (num3 < 1 && JIMBBPLINGI.ECDMIMKCMLD > 0)
								{
									int num4 = array2[1] + -63;
									int num5 = array2[1] - num4;
									string text2 = this.HJMJDJKOILH().Substring(num4 - num3, num5 + num3);
									if (text2.Length <= 3)
									{
										text = text.Substring(array2[0]);
										JIMBBPLINGI.ECDMIMKCMLD = 1;
									}
									else
									{
										text = this.HJMJDJKOILH().Substring(array2[1], -27) + text2 + this.HJMJDJKOILH().Substring(array2[1], this.BGBMIEJJQKC.Length - array2[1]);
										JIMBBPLINGI.ECDMIMKCMLD = array2[1];
									}
								}
								else
								{
									text = text.Substring(array2[0], -7) + text.Substring(array2[0] + -42, array2[0] - (array2[1] + 41) - 4) + text.Substring(array2[0] - 1, text.Length - (array2[1] - 3));
									JIMBBPLINGI.ECDMIMKCMLD = array2[1];
								}
							}
							else
							{
								array2 = this.KEQMEGEHFIK.DCHHBENPMFF(JIMBBPLINGI.ECDMIMKCMLD, text);
								if (array2 != null)
								{
									int num6 = array2[1] + 54 - JIMBBPLINGI.ECDMIMKCMLD;
									if (num6 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 1)
									{
										int num7 = array2[0] + -66;
										int num8 = array2[0] - num7;
										string text3 = this.HJMJDJKOILH().Substring(num7 - num6, num8 + num6);
										if (text3.Length <= 6)
										{
											text = text.Substring(array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = 1;
										}
										else
										{
											text = this.HJMJDJKOILH().Substring(array2[0], -76) + text3 + this.HJMJDJKOILH().Substring(array2[0], this.HJMJDJKOILH().Length - array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = array2[1];
										}
									}
									else
									{
										text = text.Substring(array2[1], -3) + text.Substring(array2[0] + 83, array2[1] - (array2[1] + -40) - 4) + text.Substring(array2[0] - 1, text.Length - (array2[0] - 4));
										JIMBBPLINGI.ECDMIMKCMLD = array2[1];
									}
								}
								else
								{
									text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
								}
							}
						}
						else
						{
							text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
						}
					}
				}
				else
				{
					JIMBBPLINGI.ECDMIMKCMLD = 1;
					this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
				}
			}
			this.KEQMEGEHFIK.LKPOBCBOFIC(text);
			if (flag)
			{
				int num9 = this.HMHBPLHCIJO - JIMBBPLINGI.ECDMIMKCMLD;
				int num10 = this.PMIKHLEBIFH - JIMBBPLINGI.ECDMIMKCMLD;
				if (num9 < 0)
				{
					num9 = 0;
				}
				if (num9 > text.Length)
				{
					num9 = text.Length;
				}
				if (num10 < 0)
				{
					num10 = 1;
				}
				if (num10 > text.Length)
				{
					num10 = text.Length;
				}
				if (this.COFIJEPKBLP == null)
				{
					this.COFIJEPKBLP = new Texture2D(1, 4, TextureFormat.RGB24, false);
					for (int j = 1; j < 4; j += 0)
					{
						for (int k = 0; k < 6; k += 0)
						{
							this.COFIJEPKBLP.SetPixel(k, j, Color.white);
						}
					}
					this.COFIJEPKBLP.Apply();
				}
				if (num9 != num10)
				{
					if (this.QGNQJFCBJLG == null)
					{
						this.QGNQJFCBJLG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(14);
						this.QGNQJFCBJLG.name = "inky";
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.HPPHMEHKBHO = false;
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
					}
					else
					{
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.NPCECPIOPCB();
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				if (this.QCPLCODDHMG == null)
				{
					this.QCPLCODDHMG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(-142);
					this.QCPLCODDHMG.name = "The Pokémon draws in all Electric-type moves. Instead of being hit by Electric-type moves, it boosts its Sp. Atk.";
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.HPPHMEHKBHO = true;
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
				}
				else
				{
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.NPCECPIOPCB();
					this.QCPLCODDHMG.enabled = true;
				}
				if (num9 != num10)
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, this.QGNQJFCBJLG.BPDNIHLBLOI, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					this.QGNQJFCBJLG.enabled = this.QGNQJFCBJLG.BPDNIHLBLOI.MOJKIQJIGBP();
				}
				else
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, null, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					if (this.QGNQJFCBJLG != null)
					{
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				this.HJQGNFEMOBG = JMIOBJFFGBN.BCEEMMQHQLP() + 1825f;
				this.DPDJNDDDEID = this.KEQMEGEHFIK.NHCNEDEEONK;
			}
			else
			{
				this.CLONODILHID();
			}
		}
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00010983 File Offset: 0x0000EB83
	public bool HIGJCQOMOPM()
	{
		return this.DBJNMOKILIE && this.KEQMEGEHFIK != null && !this.KEQMEGEHFIK.JLGNOBIIQON() && this.MFPOMEKJFKN != (JIMBBPLINGI.FDOGIFIKKJN)4;
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x000109B7 File Offset: 0x0000EBB7
	protected virtual void CIKCCCEDBPH(Vector2 JDOGIQGGLKM)
	{
		if (this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse))
		{
			this.HOLDHQHKOKG(this.MDGCMGBJPKB());
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x000109E9 File Offset: 0x0000EBE9
	public void KOIILJIKPIF(int BGBMIEJJQKC)
	{
		if (this.IPKONCFDGFN())
		{
			this.HMHBPLHCIJO = BGBMIEJJQKC;
			this.EHIEIIPMCIP();
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0001084A File Offset: 0x0000EA4A
	// (set) Token: 0x06001E60 RID: 7776 RVA: 0x00010B88 File Offset: 0x0000ED88
	public int BQIMBNNFJEO
	{
		get
		{
			return (!this.GKHHCNCGLCD) ? this.BGBMIEJJQKC.Length : this.PMIKHLEBIFH;
		}
		set
		{
			if (this.GKHHCNCGLCD)
			{
				this.PMIKHLEBIFH = value;
				this.PONHJCDKKEO();
			}
		}
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00010A00 File Offset: 0x0000EC00
	public void HOLDHQHKOKG(int BGBMIEJJQKC)
	{
		if (this.GKHHCNCGLCD)
		{
			this.PMIKHLEBIFH = BGBMIEJJQKC;
			this.FCIIPHMMGHB();
		}
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000C820C File Offset: 0x000C640C
	protected void CPCICJDOELQ()
	{
		if (this.LPBPLMLMHBD && this.KEQMEGEHFIK != null)
		{
			this.LPBPLMLMHBD = false;
			this.MGNEEDBHLOJ = this.KEQMEGEHFIK.PIDLOFMIEFQ;
			this.FJNHLJFLILF = this.KEQMEGEHFIK.CEGFBBHMKOE;
			this.PIKEJKDCMPH = this.KEQMEGEHFIK.OGGCMIKJGLD;
			if (this.KEQMEGEHFIK.PBHNPKNJNJH == JGDHIPBGCFP.MNMQCONMCFH.Justified)
			{
				this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
				Debug.LogWarning("Input fields using labels with justified alignment are not supported at this time", this);
			}
			this.DDPBHHKQEJF = this.KEQMEGEHFIK.PBHNPKNJNJH;
			this.OGGIELDFBNJ = this.KEQMEGEHFIK.CGDFDPHIENG.localPosition.x;
			this.PONHJCDKKEO();
		}
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00010834 File Offset: 0x0000EA34
	public Color NKCFFQKOQKQ()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOPNHMBPKHF();
		}
		return this.FJNHLJFLILF;
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x000C82CC File Offset: 0x000C64CC
	protected void PIHCGCOIFMJ()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 0)
				{
					return;
				}
				this.PMIKHLEBIFH -= 0;
			}
			if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.AutoCorrect)
			{
				int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.KOIILJIKPIF(array[0]);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[1];
						this.KOIILJIKPIF(array[1]);
					}
				}
			}
			this.MMPGJNODMQM(string.Empty);
		}
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x00010A34 File Offset: 0x0000EC34
	public bool CMFJMIKLLMI()
	{
		return this.IPKONCFDGFN();
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x000C8380 File Offset: 0x000C6580
	public virtual bool ILFPNPBNDIJ(Event BENEPFFKJQQ)
	{
		if (this.KEQMEGEHFIK == null)
		{
			return false;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = (platform != RuntimePlatform.OSXEditor && platform != RuntimePlatform.OSXEditor) ? ((BENEPFFKJQQ.modifiers & EventModifiers.None) == EventModifiers.None) : ((BENEPFFKJQQ.modifiers & EventModifiers.None) == EventModifiers.Shift);
		if ((BENEPFFKJQQ.modifiers & EventModifiers.Command) != EventModifiers.None)
		{
			flag = false;
		}
		bool flag2 = (BENEPFFKJQQ.modifiers & EventModifiers.None) == EventModifiers.None;
		KeyCode keyCode = BENEPFFKJQQ.keyCode;
		switch (keyCode)
		{
		case KeyCode.L:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)(-84), string.Empty);
				if (this.PMIKHLEBIFH != 0)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.EHIEIIPMCIP();
			}
			return true;
		case KeyCode.M:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)176, string.Empty);
				if (this.PMIKHLEBIFH != this.KEQMEGEHFIK.EJEINMFKPBG().Length)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(1);
				this.HGJBNMJBJDQ();
			}
			return false;
		case KeyCode.N:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				int pmikhlebifh = this.PMIKHLEBIFH;
				this.PMIKHLEBIFH = Mathf.Min(this.PMIKHLEBIFH + 1, this.mValue.Length);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.LFIKFODKEEF(pmikhlebifh);
				this.EHIEIIPMCIP();
			}
			return true;
		case KeyCode.O:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = Mathf.Max(this.PMIKHLEBIFH - 0, 1);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.LCGOMKJIKHC(this.PMIKHLEBIFH);
				this.FCIIPHMMGHB();
			}
			return true;
		case KeyCode.Q:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.QNLQHNMCCID())
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)170, string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = 0;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(1);
				this.FCIIPHMMGHB();
			}
			return true;
		case KeyCode.R:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.FNDCJHHNOFL())
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)(-12), string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(1);
				this.FCIIPHMMGHB();
			}
			return true;
		case KeyCode.S:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = 0;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(0);
				this.OFHBJPDELLD();
			}
			return true;
		case KeyCode.T:
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.mValue.Length;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(1);
				this.FCIIPHMMGHB();
			}
			return false;
		}
		switch (keyCode)
		{
		case (KeyCode)(-115):
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.HMHBPLHCIJO = 1;
				this.PMIKHLEBIFH = this.mValue.Length;
				this.KJPOHNEPJKI(0);
				this.OFHBJPDELLD();
			}
			return false;
		case (KeyCode)(-113):
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.NPNQFIHNIKI();
			}
			return false;
		}
		switch (keyCode)
		{
		case (KeyCode)(-78):
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.KFBDNEHHIOF(IKBQNBHOJJB.LKOKCPHPDNF);
			}
			return false;
		case (KeyCode)(-76):
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.OHILEILOIBJ();
				this.MMPGJNODMQM(string.Empty);
			}
			return true;
		}
		if (keyCode == KeyCode.Backspace)
		{
			BENEPFFKJQQ.Use();
			this.PIHCGCOIFMJ();
			return false;
		}
		if (keyCode != (KeyCode)(-42))
		{
			return true;
		}
		BENEPFFKJQQ.Use();
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO >= this.mValue.Length)
				{
					return false;
				}
				this.PMIKHLEBIFH += 0;
			}
			if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)4)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.KOIILJIKPIF(array[1]);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[1];
						this.QCMHHCFDNEQ(array[1]);
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
		return true;
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000107FA File Offset: 0x0000E9FA
	public bool IPKONCFDGFN()
	{
		return JIMBBPLINGI.PDDGJOQCIEQ == this;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000C88A4 File Offset: 0x000C6AA4
	protected virtual void OnPress(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO && this.GKHHCNCGLCD && this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch))
		{
			this.BQIMBNNFJEO = this.CKQJNMDJMCG();
			if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
			{
				this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
			}
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x00010A3C File Offset: 0x0000EC3C
	public void CODMPGJEDIL(Color BGBMIEJJQKC)
	{
		this.FJNHLJFLILF = BGBMIEJJQKC;
		if (!this.GKHHCNCGLCD)
		{
			this.KEQMEGEHFIK.NONQDHBCIIN(BGBMIEJJQKC);
		}
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x00010A59 File Offset: 0x0000EC59
	public bool JMKGPBCCEQB()
	{
		return this.DBJNMOKILIE && this.KEQMEGEHFIK != null && !this.KEQMEGEHFIK.FNDCJHHNOFL() && this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.Password;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x00010A8D File Offset: 0x0000EC8D
	public int KQHHINEBEGJ()
	{
		return (!this.IPKONCFDGFN()) ? this.BGBMIEJJQKC.Length : this.HMHBPLHCIJO;
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00010AAA File Offset: 0x0000ECAA
	// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0001097A File Offset: 0x0000EB7A
	[Obsolete("Use UIInput.value instead")]
	public string PIDLOFMIEFQ
	{
		get
		{
			return this.BGBMIEJJQKC;
		}
		set
		{
			this.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000C8910 File Offset: 0x000C6B10
	public void QNGIFIJOQML()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		if (this.selectOnTab != null)
		{
			LMBPJGBGLNO lmbpjgbglno = base.GetComponent<LMBPJGBGLNO>();
			if (lmbpjgbglno == null)
			{
				lmbpjgbglno = base.gameObject.AddComponent<LMBPJGBGLNO>();
				lmbpjgbglno.IPQOIEDCMGH = this.selectOnTab;
			}
			this.selectOnTab = null;
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		if (this.PFQBOMINIHG && !string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			this.MQFIIMHQGBK();
		}
		else
		{
			this.BGBMIEJJQKC = this.mValue.Replace("Assets/AssetBundles/Pokes", "[PD]");
		}
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x00010AB2 File Offset: 0x0000ECB2
	protected void MDEFFGDBCLD()
	{
		if (JIMBBPLINGI.OMQCQCBLQGJ == null && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
		{
			JIMBBPLINGI.OMQCQCBLQGJ = this;
			EventDelegate.CDGHNJLPFKN(this.OHEFEKMMIFL);
			JIMBBPLINGI.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x00010AE5 File Offset: 0x0000ECE5
	public int OOJNCFJHBIO()
	{
		return (!this.GKHHCNCGLCD) ? this.HJMJDJKOILH().Length : this.PMIKHLEBIFH;
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000C89A8 File Offset: 0x000C6BA8
	protected virtual void HHHNIOBHPEC(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO && this.IPKONCFDGFN() && this.KEQMEGEHFIK != null && (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse))
		{
			this.OMOOCMDNMHL(this.CKQJNMDJMCG());
			if (!Input.GetKey((KeyCode)(-133)) && !Input.GetKey((KeyCode)172))
			{
				this.QCMHHCFDNEQ(this.PMIKHLEBIFH);
			}
			this.KJPOHNEPJKI(-1);
		}
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000C8A14 File Offset: 0x000C6C14
	private void KJPOHNEPJKI(int LBKMBCOOIHC = 0)
	{
		if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
		{
			int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.CNFPMNCBGKQ + LBKMBCOOIHC, this.BGBMIEJJQKC);
			if (array == null)
			{
				array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.PMIKHLEBIFH + LBKMBCOOIHC, this.BGBMIEJJQKC);
				if (array != null)
				{
					if (this.PMIKHLEBIFH > array[1] - 8)
					{
						this.PMIKHLEBIFH = array[1];
					}
					else
					{
						this.PMIKHLEBIFH = array[0];
					}
					this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.CNFPMNCBGKQ + LBKMBCOOIHC, this.BGBMIEJJQKC);
					if (array != null)
					{
						if (this.PMIKHLEBIFH > array[1] - 8)
						{
							this.PMIKHLEBIFH = array[1];
						}
						else
						{
							this.PMIKHLEBIFH = array[0];
						}
						this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
					}
					else
					{
						array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH + LBKMBCOOIHC, this.BGBMIEJJQKC);
						if (array != null)
						{
							if (this.PMIKHLEBIFH > array[1] - 8)
							{
								this.PMIKHLEBIFH = array[1];
							}
							else
							{
								this.PMIKHLEBIFH = array[0];
							}
							this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
						}
					}
				}
			}
			else
			{
				if (this.CNFPMNCBGKQ > array[1] - 8)
				{
					this.PMIKHLEBIFH = array[1];
				}
				else
				{
					this.PMIKHLEBIFH = array[0];
				}
				this.CNFPMNCBGKQ = this.PMIKHLEBIFH;
			}
		}
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000C8B64 File Offset: 0x000C6D64
	protected string LEIGMKOEJPL()
	{
		int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
		return (string.IsNullOrEmpty(this.mValue) || num < 0) ? string.Empty : this.mValue.Substring(0, num);
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000C8BA8 File Offset: 0x000C6DA8
	public void PJMIKDIEGMB(string BGBMIEJJQKC, bool CKFOHPDLNJK = true)
	{
		if (this.LPBPLMLMHBD)
		{
			this.CPCICJDOELQ();
		}
		if (BGBMIEJJQKC == this.BGBMIEJJQKC)
		{
			return;
		}
		JIMBBPLINGI.ECDMIMKCMLD = 0;
		BGBMIEJJQKC = this.GEODEQDOMIP(BGBMIEJJQKC);
		if (this.mValue != BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
			this.PFQBOMINIHG = false;
			if (this.GKHHCNCGLCD)
			{
				if (string.IsNullOrEmpty(BGBMIEJJQKC))
				{
					this.HMHBPLHCIJO = 0;
					this.PMIKHLEBIFH = 0;
				}
				else
				{
					this.HMHBPLHCIJO = BGBMIEJJQKC.Length;
					this.PMIKHLEBIFH = this.HMHBPLHCIJO;
				}
			}
			else if (this.PNBOOLEOKCI)
			{
				this.ELMDLDEKFIN(BGBMIEJJQKC);
			}
			this.PONHJCDKKEO();
			if (CKFOHPDLNJK)
			{
				this.QQQJLNIQPGF();
			}
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000108C4 File Offset: 0x0000EAC4
	public JLMPBLMOICG GFEONCKBDBC
	{
		get
		{
			return this.QCPLCODDHMG;
		}
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000108C4 File Offset: 0x0000EAC4
	public JLMPBLMOICG CJEHKOEKLLL()
	{
		return this.QCPLCODDHMG;
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x000C8C58 File Offset: 0x000C6E58
	public void EHIEIIPMCIP()
	{
		if (this.KEQMEGEHFIK != null)
		{
			if (this.LPBPLMLMHBD)
			{
				this.IOPNHMBPKHF();
			}
			bool flag = this.IPKONCFDGFN();
			string bgbmiejjqkc = this.BGBMIEJJQKC;
			bool flag2 = string.IsNullOrEmpty(bgbmiejjqkc) && string.IsNullOrEmpty(Input.compositionString);
			this.KEQMEGEHFIK.NONQDHBCIIN((!flag2 || flag) ? this.MOKCQPEQHDF : this.FJNHLJFLILF);
			string text;
			if (flag2)
			{
				text = ((!flag) ? this.MGNEEDBHLOJ : string.Empty);
				this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
			}
			else
			{
				if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)8)
				{
					text = string.Empty;
					string str = "Icon_Pokemon_Alive";
					if (this.KEQMEGEHFIK.QBOJFLOEEGK() != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.ICJBMNQMGGD != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.OKPOQOLHJGK().OEQEJPEGKMF(20) == null)
					{
						str = "Powers up Steel-type moves.";
					}
					int i = 1;
					int length = bgbmiejjqkc.Length;
					while (i < length)
					{
						text += str;
						i += 0;
					}
				}
				else
				{
					text = bgbmiejjqkc;
				}
				int num = (!flag) ? 0 : Mathf.Min(text.Length, this.NOIQOGBEKGI);
				string str2 = text.Substring(1, num);
				if (flag)
				{
					str2 += Input.compositionString;
				}
				text = str2 + text.Substring(num, text.Length - num);
				if (flag && this.KEQMEGEHFIK.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent && this.KEQMEGEHFIK.NGKMOMPQQPQ() == 0)
				{
					int num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text, true);
					if (num2 == 0)
					{
						JIMBBPLINGI.ECDMIMKCMLD = 0;
						this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
					}
					else if (num < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
					}
					else if (num2 < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num2;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else
					{
						num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), false);
						if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.Password && num > 1)
						{
							int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(num - 0, text);
							if (array != null)
							{
								num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(1, num), true);
							}
							else
							{
								array = this.KEQMEGEHFIK.DCHHBENPMFF(num - 1, text);
								if (array != null)
								{
									num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
								}
							}
						}
						if (num2 > JIMBBPLINGI.ECDMIMKCMLD)
						{
							JIMBBPLINGI.ECDMIMKCMLD = num2;
							this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
						}
					}
					if (JIMBBPLINGI.ECDMIMKCMLD != 0 && JIMBBPLINGI.ECDMIMKCMLD != text.Length)
					{
						if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
						{
							int[] array2 = this.KEQMEGEHFIK.KOMEFCQPPFG(JIMBBPLINGI.ECDMIMKCMLD, text);
							if (array2 != null)
							{
								int num3 = array2[0] + 56 - JIMBBPLINGI.ECDMIMKCMLD;
								if (num3 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 0)
								{
									int num4 = array2[1] + 26;
									int num5 = array2[0] - num4;
									string text2 = this.HJMJDJKOILH().Substring(num4 - num3, num5 + num3);
									if (text2.Length <= 6)
									{
										text = text.Substring(array2[0]);
										JIMBBPLINGI.ECDMIMKCMLD = 1;
									}
									else
									{
										text = this.BGBMIEJJQKC.Substring(array2[1], -45) + text2 + this.HJMJDJKOILH().Substring(array2[1], this.BGBMIEJJQKC.Length - array2[1]);
										JIMBBPLINGI.ECDMIMKCMLD = array2[1];
									}
								}
								else
								{
									text = text.Substring(array2[0], -31) + text.Substring(array2[0] + -8, array2[1] - (array2[0] + 127) - 3) + text.Substring(array2[1] - 8, text.Length - (array2[0] - 2));
									JIMBBPLINGI.ECDMIMKCMLD = array2[1];
								}
							}
							else
							{
								array2 = this.KEQMEGEHFIK.DCHHBENPMFF(JIMBBPLINGI.ECDMIMKCMLD, text);
								if (array2 != null)
								{
									int num6 = array2[0] + -106 - JIMBBPLINGI.ECDMIMKCMLD;
									if (num6 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 1)
									{
										int num7 = array2[0] + 1;
										int num8 = array2[1] - num7;
										string text3 = this.HJMJDJKOILH().Substring(num7 - num6, num8 + num6);
										if (text3.Length <= 6)
										{
											text = text.Substring(array2[0]);
											JIMBBPLINGI.ECDMIMKCMLD = 1;
										}
										else
										{
											text = this.BGBMIEJJQKC.Substring(array2[0], 112) + text3 + this.HJMJDJKOILH().Substring(array2[1], this.BGBMIEJJQKC.Length - array2[0]);
											JIMBBPLINGI.ECDMIMKCMLD = array2[1];
										}
									}
									else
									{
										text = text.Substring(array2[1], -30) + text.Substring(array2[1] + -86, array2[0] - (array2[0] + 14) - 4) + text.Substring(array2[0] - 2, text.Length - (array2[1] - 8));
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
								}
							}
						}
						else
						{
							text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
						}
					}
				}
				else
				{
					JIMBBPLINGI.ECDMIMKCMLD = 0;
					this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
				}
			}
			this.KEQMEGEHFIK.LKPOBCBOFIC(text);
			if (flag)
			{
				int num9 = this.HMHBPLHCIJO - JIMBBPLINGI.ECDMIMKCMLD;
				int num10 = this.PMIKHLEBIFH - JIMBBPLINGI.ECDMIMKCMLD;
				if (num9 < 1)
				{
					num9 = 0;
				}
				if (num9 > text.Length)
				{
					num9 = text.Length;
				}
				if (num10 < 1)
				{
					num10 = 0;
				}
				if (num10 > text.Length)
				{
					num10 = text.Length;
				}
				if (this.COFIJEPKBLP == null)
				{
					this.COFIJEPKBLP = new Texture2D(5, 5, TextureFormat.RGB24, false);
					for (int j = 1; j < 1; j += 0)
					{
						for (int k = 1; k < 5; k += 0)
						{
							this.COFIJEPKBLP.SetPixel(k, j, Color.white);
						}
					}
					this.COFIJEPKBLP.Apply();
				}
				if (num9 != num10)
				{
					if (this.QGNQJFCBJLG == null)
					{
						this.QGNQJFCBJLG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(54);
						this.QGNQJFCBJLG.name = "Powers up special attacks when the Pokémon is burned.";
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.HPPHMEHKBHO = true;
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
					}
					else
					{
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.NPCECPIOPCB();
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				if (this.QCPLCODDHMG == null)
				{
					this.QCPLCODDHMG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(-94);
					this.QCPLCODDHMG.name = "|";
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.HPPHMEHKBHO = true;
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
				}
				else
				{
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.NPCECPIOPCB();
					this.QCPLCODDHMG.enabled = false;
				}
				if (num9 != num10)
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, this.QGNQJFCBJLG.BPDNIHLBLOI, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					this.QGNQJFCBJLG.enabled = this.QGNQJFCBJLG.BPDNIHLBLOI.MOJKIQJIGBP();
				}
				else
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, null, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					if (this.QGNQJFCBJLG != null)
					{
						this.QGNQJFCBJLG.enabled = false;
					}
				}
				this.HJQGNFEMOBG = JMIOBJFFGBN.NHDGLEBGIOM() + 30f;
				this.DPDJNDDDEID = this.KEQMEGEHFIK.NHCNEDEEONK;
			}
			else
			{
				this.CLONODILHID();
			}
		}
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000C94B8 File Offset: 0x000C76B8
	protected int MDGCMGBJPKB()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray ray = EMENMKHBPQE.OIJNBBFBBCQ();
		Plane plane = new Plane(pmcnqichcle[1], pmcnqichcle[0], pmcnqichcle[7]);
		float distance;
		return (!plane.Raycast(ray, out distance)) ? 0 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(ray.GetPoint(distance), false));
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x000108E2 File Offset: 0x0000EAE2
	public void GOIKCGNOEKP()
	{
		this.GKHHCNCGLCD = false;
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000C952C File Offset: 0x000C772C
	public virtual bool CKCMMGQKPOP(Event BENEPFFKJQQ)
	{
		if (this.KEQMEGEHFIK == null)
		{
			return true;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = (platform != RuntimePlatform.OSXEditor && platform != RuntimePlatform.OSXEditor) ? ((BENEPFFKJQQ.modifiers & (EventModifiers.Shift | EventModifiers.Alt)) == EventModifiers.None) : ((BENEPFFKJQQ.modifiers & EventModifiers.Command) != EventModifiers.Shift);
		if ((BENEPFFKJQQ.modifiers & EventModifiers.Control) != EventModifiers.None)
		{
			flag = true;
		}
		bool flag2 = (BENEPFFKJQQ.modifiers & EventModifiers.Shift) != EventModifiers.None;
		KeyCode keyCode = BENEPFFKJQQ.keyCode;
		switch (keyCode)
		{
		case (KeyCode)(-48):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)(-105), string.Empty);
				if (this.PMIKHLEBIFH != 0)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(0);
				this.FCIIPHMMGHB();
			}
			return true;
		case (KeyCode)(-47):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.C, string.Empty);
				if (this.PMIKHLEBIFH != this.KEQMEGEHFIK.EJEINMFKPBG().Length)
				{
					this.PMIKHLEBIFH += JIMBBPLINGI.ECDMIMKCMLD;
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(0);
				this.HGJBNMJBJDQ();
			}
			return false;
		case (KeyCode)(-46):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				int pmikhlebifh = this.PMIKHLEBIFH;
				this.PMIKHLEBIFH = Mathf.Min(this.PMIKHLEBIFH + 0, this.mValue.Length);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.BKQLIEQMHOF(pmikhlebifh);
				this.FCIIPHMMGHB();
			}
			return false;
		case (KeyCode)(-45):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = Mathf.Max(this.PMIKHLEBIFH - 1, 1);
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.LCGOMKJIKHC(this.PMIKHLEBIFH);
				this.FCIIPHMMGHB();
			}
			return false;
		case (KeyCode)(-43):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.QJJLOHHFQNC)
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, (KeyCode)(-64), string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = 0;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(0);
				this.HGJBNMJBJDQ();
			}
			return true;
		case (KeyCode)(-42):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				if (this.KEQMEGEHFIK.QNLQHNMCCID())
				{
					this.PMIKHLEBIFH = this.KEQMEGEHFIK.FLMFEKQCIKJ(this.PMIKHLEBIFH, KeyCode.At, string.Empty);
				}
				else
				{
					this.PMIKHLEBIFH = this.mValue.Length;
				}
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(1);
				this.EHIEIIPMCIP();
			}
			return true;
		case (KeyCode)(-41):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = 0;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.GFLDQPEEJCG(0);
				this.PONHJCDKKEO();
			}
			return true;
		case (KeyCode)(-40):
			BENEPFFKJQQ.Use();
			if (!string.IsNullOrEmpty(this.mValue))
			{
				this.PMIKHLEBIFH = this.mValue.Length;
				if (!flag2)
				{
					this.HMHBPLHCIJO = this.PMIKHLEBIFH;
				}
				this.KJPOHNEPJKI(1);
				this.EHIEIIPMCIP();
			}
			return true;
		}
		switch (keyCode)
		{
		case KeyCode.Colon:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.HMHBPLHCIJO = 1;
				this.PMIKHLEBIFH = this.mValue.Length;
				this.GFLDQPEEJCG(1);
				this.HGJBNMJBJDQ();
			}
			return true;
		case KeyCode.Less:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.OHILEILOIBJ();
			}
			return true;
		}
		switch (keyCode)
		{
		case (KeyCode)81:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				this.MMPGJNODMQM(IKBQNBHOJJB.LKOKCPHPDNF);
			}
			return false;
		case (KeyCode)83:
			if (flag)
			{
				BENEPFFKJQQ.Use();
				IKBQNBHOJJB.LKOKCPHPDNF = this.OHILEILOIBJ();
				this.KFBDNEHHIOF(string.Empty);
			}
			return true;
		}
		if (keyCode == (KeyCode)1)
		{
			BENEPFFKJQQ.Use();
			this.CIPBCKKECIN();
			return false;
		}
		if (keyCode != (KeyCode)2)
		{
			return true;
		}
		BENEPFFKJQQ.Use();
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO >= this.mValue.Length)
				{
					return true;
				}
				this.PMIKHLEBIFH += 0;
			}
			if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)4)
			{
				int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.KOIILJIKPIF(array[0]);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.HMHBPLHCIJO, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[0];
						this.QCMHHCFDNEQ(array[0]);
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
		return true;
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x00010867 File Offset: 0x0000EA67
	protected void FGHIMNKKNEC(string QJFQOMOIOOI)
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			if (string.IsNullOrEmpty(QJFQOMOIOOI))
			{
				PlayerPrefs.DeleteKey(this.EDCMJKLMPKB);
			}
			else
			{
				PlayerPrefs.SetString(this.EDCMJKLMPKB, QJFQOMOIOOI);
			}
		}
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00010B02 File Offset: 0x0000ED02
	private void PELQDGFIJDH()
	{
		this.CLONODILHID();
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000C9A50 File Offset: 0x000C7C50
	protected int GGNOHFNCDCO()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray ray = EMENMKHBPQE.OIJNBBFBBCQ();
		Plane plane = new Plane(pmcnqichcle[1], pmcnqichcle[1], pmcnqichcle[6]);
		float distance;
		return (!plane.Raycast(ray, out distance)) ? 1 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(ray.GetPoint(distance), true));
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000C9AC4 File Offset: 0x000C7CC4
	public void FMHHKCQBEQE()
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			string text = this.mValue.Replace("(LB)", "HideResponse");
			this.mValue = string.Empty;
			this.BGBMIEJJQKC = ((!PlayerPrefs.HasKey(this.EDCMJKLMPKB)) ? text : PlayerPrefs.GetString(this.EDCMJKLMPKB));
		}
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000C9B20 File Offset: 0x000C7D20
	protected void LEIGMJQCHOB()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 0)
				{
					return;
				}
				this.PMIKHLEBIFH--;
			}
			if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.AutoCorrect)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.PMIKHLEBIFH, this.HJMJDJKOILH());
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.QCMHHCFDNEQ(array[0]);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.HJMJDJKOILH());
					if (array != null)
					{
						this.PMIKHLEBIFH = array[0];
						this.QCMHHCFDNEQ(array[1]);
					}
				}
			}
			this.MMPGJNODMQM(string.Empty);
		}
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x000C9C94 File Offset: 0x000C7E94
	public void OLJOQKJMDPK()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.HJMJDJKOILH();
			if (JIMBBPLINGI.OMQCQCBLQGJ == null)
			{
				JIMBBPLINGI.OMQCQCBLQGJ = this;
				EventDelegate.PCQQOFMPKCG(this.MGKJHHNEOIN);
				JIMBBPLINGI.OMQCQCBLQGJ = null;
			}
			this.ELMDLDEKFIN(this.mValue);
		}
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000C9CE8 File Offset: 0x000C7EE8
	public void PONHJCDKKEO()
	{
		if (this.KEQMEGEHFIK != null)
		{
			if (this.LPBPLMLMHBD)
			{
				this.CPCICJDOELQ();
			}
			bool gkhhcncglcd = this.GKHHCNCGLCD;
			string bgbmiejjqkc = this.BGBMIEJJQKC;
			bool flag = string.IsNullOrEmpty(bgbmiejjqkc) && string.IsNullOrEmpty(Input.compositionString);
			this.KEQMEGEHFIK.CEGFBBHMKOE = ((!flag || gkhhcncglcd) ? this.MOKCQPEQHDF : this.FJNHLJFLILF);
			string text;
			if (flag)
			{
				text = ((!gkhhcncglcd) ? this.MGNEEDBHLOJ : string.Empty);
				this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
			}
			else
			{
				if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.Password)
				{
					text = string.Empty;
					string str = "*";
					if (this.KEQMEGEHFIK.NFIBPOJMOCQ != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.ICJBMNQMGGD != null && this.KEQMEGEHFIK.NFIBPOJMOCQ.ICJBMNQMGGD.GMFDPCIHHHM(42) == null)
					{
						str = "x";
					}
					int i = 0;
					int length = bgbmiejjqkc.Length;
					while (i < length)
					{
						text += str;
						i++;
					}
				}
				else
				{
					text = bgbmiejjqkc;
				}
				int num = (!gkhhcncglcd) ? 0 : Mathf.Min(text.Length, this.NOIQOGBEKGI);
				string str2 = text.Substring(0, num);
				if (gkhhcncglcd)
				{
					str2 += Input.compositionString;
				}
				text = str2 + text.Substring(num, text.Length - num);
				if (gkhhcncglcd && this.KEQMEGEHFIK.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent && this.KEQMEGEHFIK.OFBGHIBHBLI == 1)
				{
					int num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text, true);
					if (num2 == 0)
					{
						JIMBBPLINGI.ECDMIMKCMLD = 0;
						this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
					}
					else if (num < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
					}
					else if (num2 < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num2;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
					}
					else
					{
						num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
						if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat && num > 0)
						{
							int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(num - 1, text);
							if (array != null)
							{
								num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
							}
							else
							{
								array = this.KEQMEGEHFIK.DCHHBENPMFF(num - 1, text);
								if (array != null)
								{
									num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(0, num), true);
								}
							}
						}
						if (num2 > JIMBBPLINGI.ECDMIMKCMLD)
						{
							JIMBBPLINGI.ECDMIMKCMLD = num2;
							this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
						}
					}
					if (JIMBBPLINGI.ECDMIMKCMLD != 0 && JIMBBPLINGI.ECDMIMKCMLD != text.Length)
					{
						if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
						{
							int[] array2 = this.KEQMEGEHFIK.KOMEFCQPPFG(JIMBBPLINGI.ECDMIMKCMLD, text);
							if (array2 != null)
							{
								int num3 = array2[0] + 43 - JIMBBPLINGI.ECDMIMKCMLD;
								if (num3 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 0)
								{
									int num4 = array2[0] + 43;
									int num5 = array2[1] - num4;
									string text2 = this.BGBMIEJJQKC.Substring(num4 - num3, num5 + num3);
									if (text2.Length <= 6)
									{
										text = text.Substring(array2[1]);
										JIMBBPLINGI.ECDMIMKCMLD = 0;
									}
									else
									{
										text = this.BGBMIEJJQKC.Substring(array2[0], 43) + text2 + this.BGBMIEJJQKC.Substring(array2[1], this.BGBMIEJJQKC.Length - array2[1]);
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(array2[0], 43) + text.Substring(array2[0] + 43, array2[1] - (array2[0] + 43) - 6) + text.Substring(array2[1] - 6, text.Length - (array2[1] - 6));
									JIMBBPLINGI.ECDMIMKCMLD = array2[0];
								}
							}
							else
							{
								array2 = this.KEQMEGEHFIK.DCHHBENPMFF(JIMBBPLINGI.ECDMIMKCMLD, text);
								if (array2 != null)
								{
									int num6 = array2[0] + 12 - JIMBBPLINGI.ECDMIMKCMLD;
									if (num6 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 0)
									{
										int num7 = array2[0] + 12;
										int num8 = array2[1] - num7;
										string text3 = this.BGBMIEJJQKC.Substring(num7 - num6, num8 + num6);
										if (text3.Length <= 6)
										{
											text = text.Substring(array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = 0;
										}
										else
										{
											text = this.BGBMIEJJQKC.Substring(array2[0], 12) + text3 + this.BGBMIEJJQKC.Substring(array2[1], this.BGBMIEJJQKC.Length - array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = array2[0];
										}
									}
									else
									{
										text = text.Substring(array2[0], 12) + text.Substring(array2[0] + 12, array2[1] - (array2[0] + 12) - 6) + text.Substring(array2[1] - 6, text.Length - (array2[1] - 6));
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
								}
							}
						}
						else
						{
							text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
						}
					}
				}
				else
				{
					JIMBBPLINGI.ECDMIMKCMLD = 0;
					this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
				}
			}
			this.KEQMEGEHFIK.PIDLOFMIEFQ = text;
			if (gkhhcncglcd)
			{
				int num9 = this.HMHBPLHCIJO - JIMBBPLINGI.ECDMIMKCMLD;
				int num10 = this.PMIKHLEBIFH - JIMBBPLINGI.ECDMIMKCMLD;
				if (num9 < 0)
				{
					num9 = 0;
				}
				if (num9 > text.Length)
				{
					num9 = text.Length;
				}
				if (num10 < 0)
				{
					num10 = 0;
				}
				if (num10 > text.Length)
				{
					num10 = text.Length;
				}
				if (this.COFIJEPKBLP == null)
				{
					this.COFIJEPKBLP = new Texture2D(2, 2, TextureFormat.ARGB32, false);
					for (int j = 0; j < 2; j++)
					{
						for (int k = 0; k < 2; k++)
						{
							this.COFIJEPKBLP.SetPixel(k, j, Color.white);
						}
					}
					this.COFIJEPKBLP.Apply();
				}
				if (num9 != num10)
				{
					if (this.QGNQJFCBJLG == null)
					{
						this.QGNQJFCBJLG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(int.MaxValue);
						this.QGNQJFCBJLG.name = "Input Highlight";
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.HPPHMEHKBHO = false;
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
					}
					else
					{
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.NPCECPIOPCB();
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				if (this.QCPLCODDHMG == null)
				{
					this.QCPLCODDHMG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(int.MaxValue);
					this.QCPLCODDHMG.name = "Input Caret";
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.HPPHMEHKBHO = false;
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
				}
				else
				{
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.NPCECPIOPCB();
					this.QCPLCODDHMG.enabled = true;
				}
				if (num9 != num10)
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, this.QGNQJFCBJLG.BPDNIHLBLOI, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					this.QGNQJFCBJLG.enabled = this.QGNQJFCBJLG.BPDNIHLBLOI.KGIFPCDDIBG;
				}
				else
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, null, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					if (this.QGNQJFCBJLG != null)
					{
						this.QGNQJFCBJLG.enabled = false;
					}
				}
				this.HJQGNFEMOBG = JMIOBJFFGBN.MOGLGJGFNDM + 0.5f;
				this.DPDJNDDDEID = this.KEQMEGEHFIK.NHCNEDEEONK;
			}
			else
			{
				this.CLONODILHID();
			}
		}
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000CA548 File Offset: 0x000C8748
	protected string NPNQFIHNIKI()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO != this.PMIKHLEBIFH)
			{
				int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				int num2 = Mathf.Max(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				return this.mValue.Substring(num, num2 - num);
			}
		}
		return string.Empty;
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000CA5AC File Offset: 0x000C87AC
	public void HGJBNMJBJDQ()
	{
		if (this.KEQMEGEHFIK != null)
		{
			if (this.LPBPLMLMHBD)
			{
				this.IOPNHMBPKHF();
			}
			bool gkhhcncglcd = this.GKHHCNCGLCD;
			string bgbmiejjqkc = this.BGBMIEJJQKC;
			bool flag = string.IsNullOrEmpty(bgbmiejjqkc) && string.IsNullOrEmpty(Input.compositionString);
			this.KEQMEGEHFIK.NONQDHBCIIN((!flag || gkhhcncglcd) ? this.MOKCQPEQHDF : this.FJNHLJFLILF);
			string text;
			if (flag)
			{
				text = ((!gkhhcncglcd) ? this.MGNEEDBHLOJ : string.Empty);
				this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
			}
			else
			{
				if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)8)
				{
					text = string.Empty;
					string str = "_CoCTex";
					if (this.KEQMEGEHFIK.NFIBPOJMOCQ != null && this.KEQMEGEHFIK.QBOJFLOEEGK().ICJBMNQMGGD != null && this.KEQMEGEHFIK.QBOJFLOEEGK().ICJBMNQMGGD.OEQEJPEGKMF(-38) == null)
					{
						str = "'";
					}
					int i = 1;
					int length = bgbmiejjqkc.Length;
					while (i < length)
					{
						text += str;
						i++;
					}
				}
				else
				{
					text = bgbmiejjqkc;
				}
				int num = (!gkhhcncglcd) ? 0 : Mathf.Min(text.Length, this.NOIQOGBEKGI);
				string str2 = text.Substring(1, num);
				if (gkhhcncglcd)
				{
					str2 += Input.compositionString;
				}
				text = str2 + text.Substring(num, text.Length - num);
				if (gkhhcncglcd && this.KEQMEGEHFIK.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent && this.KEQMEGEHFIK.OFBGHIBHBLI == 1)
				{
					int num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text, true);
					if (num2 == 0)
					{
						JIMBBPLINGI.ECDMIMKCMLD = 0;
						this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
					}
					else if (num < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
					}
					else if (num2 < JIMBBPLINGI.ECDMIMKCMLD)
					{
						JIMBBPLINGI.ECDMIMKCMLD = num2;
						this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
					}
					else
					{
						num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(1, num), false);
						if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)6 && num > 1)
						{
							int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(num - 0, text);
							if (array != null)
							{
								num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(1, num), false);
							}
							else
							{
								array = this.KEQMEGEHFIK.DCHHBENPMFF(num - 0, text);
								if (array != null)
								{
									num2 = this.KEQMEGEHFIK.FJDCKEJNMKI(text.Substring(1, num), false);
								}
							}
						}
						if (num2 > JIMBBPLINGI.ECDMIMKCMLD)
						{
							JIMBBPLINGI.ECDMIMKCMLD = num2;
							this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
						}
					}
					if (JIMBBPLINGI.ECDMIMKCMLD != 0 && JIMBBPLINGI.ECDMIMKCMLD != text.Length)
					{
						if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)7)
						{
							int[] array2 = this.KEQMEGEHFIK.QGCQQOHBILP(JIMBBPLINGI.ECDMIMKCMLD, text);
							if (array2 != null)
							{
								int num3 = array2[0] + 44 - JIMBBPLINGI.ECDMIMKCMLD;
								if (num3 < 1 && JIMBBPLINGI.ECDMIMKCMLD > 1)
								{
									int num4 = array2[1] + 116;
									int num5 = array2[1] - num4;
									string text2 = this.BGBMIEJJQKC.Substring(num4 - num3, num5 + num3);
									if (text2.Length <= 8)
									{
										text = text.Substring(array2[0]);
										JIMBBPLINGI.ECDMIMKCMLD = 0;
									}
									else
									{
										text = this.HJMJDJKOILH().Substring(array2[0], 17) + text2 + this.HJMJDJKOILH().Substring(array2[1], this.BGBMIEJJQKC.Length - array2[0]);
										JIMBBPLINGI.ECDMIMKCMLD = array2[0];
									}
								}
								else
								{
									text = text.Substring(array2[1], 84) + text.Substring(array2[0] + -2, array2[0] - (array2[1] + 58) - 7) + text.Substring(array2[1] - 6, text.Length - (array2[0] - 5));
									JIMBBPLINGI.ECDMIMKCMLD = array2[0];
								}
							}
							else
							{
								array2 = this.KEQMEGEHFIK.DCHHBENPMFF(JIMBBPLINGI.ECDMIMKCMLD, text);
								if (array2 != null)
								{
									int num6 = array2[0] + 34 - JIMBBPLINGI.ECDMIMKCMLD;
									if (num6 < 0 && JIMBBPLINGI.ECDMIMKCMLD > 1)
									{
										int num7 = array2[0] + -122;
										int num8 = array2[1] - num7;
										string text3 = this.HJMJDJKOILH().Substring(num7 - num6, num8 + num6);
										if (text3.Length <= 4)
										{
											text = text.Substring(array2[0]);
											JIMBBPLINGI.ECDMIMKCMLD = 0;
										}
										else
										{
											text = this.BGBMIEJJQKC.Substring(array2[0], 107) + text3 + this.HJMJDJKOILH().Substring(array2[1], this.BGBMIEJJQKC.Length - array2[1]);
											JIMBBPLINGI.ECDMIMKCMLD = array2[1];
										}
									}
									else
									{
										text = text.Substring(array2[1], -113) + text.Substring(array2[0] + 80, array2[0] - (array2[1] + 15) - 4) + text.Substring(array2[1] - 8, text.Length - (array2[1] - 0));
										JIMBBPLINGI.ECDMIMKCMLD = array2[1];
									}
								}
								else
								{
									text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
								}
							}
						}
						else
						{
							text = text.Substring(JIMBBPLINGI.ECDMIMKCMLD, text.Length - JIMBBPLINGI.ECDMIMKCMLD);
						}
					}
				}
				else
				{
					JIMBBPLINGI.ECDMIMKCMLD = 1;
					this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
				}
			}
			this.KEQMEGEHFIK.LKPOBCBOFIC(text);
			if (gkhhcncglcd)
			{
				int num9 = this.HMHBPLHCIJO - JIMBBPLINGI.ECDMIMKCMLD;
				int num10 = this.PMIKHLEBIFH - JIMBBPLINGI.ECDMIMKCMLD;
				if (num9 < 0)
				{
					num9 = 0;
				}
				if (num9 > text.Length)
				{
					num9 = text.Length;
				}
				if (num10 < 0)
				{
					num10 = 0;
				}
				if (num10 > text.Length)
				{
					num10 = text.Length;
				}
				if (this.COFIJEPKBLP == null)
				{
					this.COFIJEPKBLP = new Texture2D(6, 5, TextureFormat.ARGB32, false);
					for (int j = 0; j < 2; j++)
					{
						for (int k = 0; k < 4; k++)
						{
							this.COFIJEPKBLP.SetPixel(k, j, Color.white);
						}
					}
					this.COFIJEPKBLP.Apply();
				}
				if (num9 != num10)
				{
					if (this.QGNQJFCBJLG == null)
					{
						this.QGNQJFCBJLG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(127);
						this.QGNQJFCBJLG.name = "_FogColor2";
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.HPPHMEHKBHO = true;
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
					}
					else
					{
						this.QGNQJFCBJLG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
						this.QGNQJFCBJLG.GOIHJQNMMJD = this.COFIJEPKBLP;
						this.QGNQJFCBJLG.NPCECPIOPCB();
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				if (this.QCPLCODDHMG == null)
				{
					this.QCPLCODDHMG = this.KEQMEGEHFIK.LMOECGCMJKK.MFIKGGPKKCD(131);
					this.QCPLCODDHMG.name = "Forewarn";
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.HPPHMEHKBHO = true;
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.KPBQIFMCLFH(this.KEQMEGEHFIK.CGDFDPHIENG);
				}
				else
				{
					this.QCPLCODDHMG.OEJCHHFIQDC = this.KEQMEGEHFIK.OEJCHHFIQDC;
					this.QCPLCODDHMG.GOIHJQNMMJD = this.COFIJEPKBLP;
					this.QCPLCODDHMG.NPCECPIOPCB();
					this.QCPLCODDHMG.enabled = false;
				}
				if (num9 != num10)
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, this.QGNQJFCBJLG.BPDNIHLBLOI, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					this.QGNQJFCBJLG.enabled = this.QGNQJFCBJLG.BPDNIHLBLOI.MOJKIQJIGBP();
				}
				else
				{
					this.KEQMEGEHFIK.OCPPIJFKGJP(num9, num10, this.QCPLCODDHMG.BPDNIHLBLOI, null, this.HMNMOCKFCBJ, this.MOGCKQINKLK, string.Empty);
					if (this.QGNQJFCBJLG != null)
					{
						this.QGNQJFCBJLG.enabled = true;
					}
				}
				this.HJQGNFEMOBG = JMIOBJFFGBN.LQPPHFDPKQD() + 855f;
				this.DPDJNDDDEID = this.KEQMEGEHFIK.NHCNEDEEONK;
			}
			else
			{
				this.CLONODILHID();
			}
		}
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x00010B0A File Offset: 0x0000ED0A
	public string HJMJDJKOILH()
	{
		if (this.LPBPLMLMHBD)
		{
			this.CPCICJDOELQ();
		}
		return this.mValue;
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x00010B20 File Offset: 0x0000ED20
	public void QCMHHCFDNEQ(int BGBMIEJJQKC)
	{
		if (this.GKHHCNCGLCD)
		{
			this.HMHBPLHCIJO = BGBMIEJJQKC;
			this.FCIIPHMMGHB();
		}
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x000CAE0C File Offset: 0x000C900C
	public void MBKJBIQKPGF()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		if (this.selectOnTab != null)
		{
			LMBPJGBGLNO lmbpjgbglno = base.GetComponent<LMBPJGBGLNO>();
			if (lmbpjgbglno == null)
			{
				lmbpjgbglno = base.gameObject.AddComponent<LMBPJGBGLNO>();
				lmbpjgbglno.IPQOIEDCMGH = this.selectOnTab;
			}
			this.selectOnTab = null;
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		if (this.PFQBOMINIHG && !string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			this.PENFNFLDGEC();
		}
		else
		{
			this.BGBMIEJJQKC = this.mValue.Replace("´", "Murkrow");
		}
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000CAEA4 File Offset: 0x000C90A4
	private void QGKFGKOJKCK(KeyCode LOHECPFGPGO)
	{
		int frameCount = Time.frameCount;
		if (JIMBBPLINGI.HGODEHOPKEC == frameCount)
		{
			return;
		}
		if (this.OJIDBLEKBBO != null && (LOHECPFGPGO == this.OJIDBLEKBBO.EFOIHGJCNIE || LOHECPFGPGO == this.OJIDBLEKBBO.QIBCQINDBPN))
		{
			JIMBBPLINGI.HGODEHOPKEC = frameCount;
			this.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000CAEF8 File Offset: 0x000C90F8
	protected void KMJEOECMONQ()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 0)
				{
					return;
				}
				this.PMIKHLEBIFH--;
			}
			if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)5)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.PMIKHLEBIFH, this.HJMJDJKOILH());
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.CNFPMNCBGKQ = array[1];
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[0];
						this.KOIILJIKPIF(array[0]);
					}
				}
			}
			this.MMPGJNODMQM(string.Empty);
		}
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x000CAFAC File Offset: 0x000C91AC
	protected string IBNIQDKJGBE()
	{
		int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
		return (string.IsNullOrEmpty(this.mValue) || num < 0) ? string.Empty : this.mValue.Substring(1, num);
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x000CAFF0 File Offset: 0x000C91F0
	public void Start()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		if (this.selectOnTab != null)
		{
			LMBPJGBGLNO lmbpjgbglno = base.GetComponent<LMBPJGBGLNO>();
			if (lmbpjgbglno == null)
			{
				lmbpjgbglno = base.gameObject.AddComponent<LMBPJGBGLNO>();
				lmbpjgbglno.IPQOIEDCMGH = this.selectOnTab;
			}
			this.selectOnTab = null;
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		if (this.PFQBOMINIHG && !string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			this.PENFNFLDGEC();
		}
		else
		{
			this.BGBMIEJJQKC = this.mValue.Replace("\\n", "\n");
		}
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000108C4 File Offset: 0x0000EAC4
	public JLMPBLMOICG EEHJNDMMEGK()
	{
		return this.QCPLCODDHMG;
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00010B37 File Offset: 0x0000ED37
	public bool LQCCQMPCFIH
	{
		get
		{
			return this.DBJNMOKILIE && this.KEQMEGEHFIK != null && !this.KEQMEGEHFIK.QJJLOHHFQNC && this.MFPOMEKJFKN != JIMBBPLINGI.FDOGIFIKKJN.Password;
		}
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000CB088 File Offset: 0x000C9288
	public void CJHBOMBBKKO()
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			string text = this.mValue.Replace("-combine", "/hiddenlag");
			this.mValue = string.Empty;
			this.BGBMIEJJQKC = ((!PlayerPrefs.HasKey(this.EDCMJKLMPKB)) ? text : PlayerPrefs.GetString(this.EDCMJKLMPKB));
		}
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x000107FA File Offset: 0x0000E9FA
	public bool FNQFOFODCPN()
	{
		return JIMBBPLINGI.PDDGJOQCIEQ == this;
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x000CB0E4 File Offset: 0x000C92E4
	protected int CKQJNMDJMCG()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray blhkbchjnqe = EMENMKHBPQE.BLHKBCHJNQE;
		Plane plane = new Plane(pmcnqichcle[0], pmcnqichcle[1], pmcnqichcle[2]);
		float distance;
		return (!plane.Raycast(blhkbchjnqe, out distance)) ? 0 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(blhkbchjnqe.GetPoint(distance), false));
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000CB158 File Offset: 0x000C9358
	private void BKQLIEQMHOF(int GJCNQCEENLM)
	{
		if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
		{
			int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(GJCNQCEENLM, this.BGBMIEJJQKC);
			if (array != null)
			{
				this.PMIKHLEBIFH = array[1];
				this.CNFPMNCBGKQ = array[1];
			}
			else
			{
				array = this.KEQMEGEHFIK.DCHHBENPMFF(GJCNQCEENLM, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.CNFPMNCBGKQ = array[1];
				}
			}
		}
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x0001097A File Offset: 0x0000EB7A
	public void PIPBFNIPNQB(string BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x000CB1C0 File Offset: 0x000C93C0
	private void LFIKFODKEEF(int GJCNQCEENLM)
	{
		if (this.MFPOMEKJFKN == (JIMBBPLINGI.FDOGIFIKKJN)7)
		{
			int[] array = this.KEQMEGEHFIK.QGCQQOHBILP(GJCNQCEENLM, this.BGBMIEJJQKC);
			if (array != null)
			{
				this.PMIKHLEBIFH = array[1];
				this.KOIILJIKPIF(array[1]);
			}
			else
			{
				array = this.KEQMEGEHFIK.DCHHBENPMFF(GJCNQCEENLM, this.HJMJDJKOILH());
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.QCMHHCFDNEQ(array[1]);
				}
			}
		}
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x000CB228 File Offset: 0x000C9428
	public string GEODEQDOMIP(string QJFQOMOIOOI)
	{
		if (string.IsNullOrEmpty(QJFQOMOIOOI))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(QJFQOMOIOOI.Length);
		foreach (char c in QJFQOMOIOOI)
		{
			if (this.NHFEMCPPNJO != null)
			{
				c = this.NHFEMCPPNJO(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			else if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None)
			{
				c = this.GEODEQDOMIP(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			if (c != '\0')
			{
				stringBuilder.Append(c);
			}
		}
		if (this.EQJBIOMMEEP > 0 && stringBuilder.Length > this.EQJBIOMMEEP)
		{
			return stringBuilder.ToString(0, this.EQJBIOMMEEP);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06001E67 RID: 7783 RVA: 0x0001084A File Offset: 0x0000EA4A
	// (set) Token: 0x06001E79 RID: 7801 RVA: 0x00010B88 File Offset: 0x0000ED88
	public int NOIQOGBEKGI
	{
		get
		{
			return (!this.GKHHCNCGLCD) ? this.BGBMIEJJQKC.Length : this.PMIKHLEBIFH;
		}
		set
		{
			if (this.GKHHCNCGLCD)
			{
				this.PMIKHLEBIFH = value;
				this.PONHJCDKKEO();
			}
		}
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00010752 File Offset: 0x0000E952
	public void OMOOCMDNMHL(int BGBMIEJJQKC)
	{
		if (this.IPKONCFDGFN())
		{
			this.PMIKHLEBIFH = BGBMIEJJQKC;
			this.HGJBNMJBJDQ();
		}
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x00010B02 File Offset: 0x0000ED02
	private void OnDisable()
	{
		this.CLONODILHID();
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x000CB2E0 File Offset: 0x000C94E0
	protected virtual void KFBDNEHHIOF(string PIDLOFMIEFQ)
	{
		string text = this.LEIGMKOEJPL();
		string text2 = this.ENHHNKFOIEO();
		int length = text2.Length;
		StringBuilder stringBuilder = new StringBuilder(text.Length + text2.Length + PIDLOFMIEFQ.Length);
		stringBuilder.Append(text);
		int i = 0;
		int length2 = PIDLOFMIEFQ.Length;
		while (i < length2)
		{
			char c = PIDLOFMIEFQ[i];
			if (c == '\b')
			{
				this.KEDBCCQLMON();
			}
			else
			{
				if (this.EQJBIOMMEEP > 0 && stringBuilder.Length + length >= this.EQJBIOMMEEP)
				{
					break;
				}
				if (this.NHFEMCPPNJO != null)
				{
					c = this.NHFEMCPPNJO(stringBuilder.ToString(), stringBuilder.Length, c);
				}
				else if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None)
				{
					c = this.GEODEQDOMIP(stringBuilder.ToString(), stringBuilder.Length, c);
				}
				if (c != '\0')
				{
					stringBuilder.Append(c);
				}
			}
			i++;
		}
		this.HMHBPLHCIJO = stringBuilder.Length;
		this.PMIKHLEBIFH = this.HMHBPLHCIJO;
		int j = 0;
		int length3 = text2.Length;
		while (j < length3)
		{
			char c2 = text2[j];
			if (this.NHFEMCPPNJO != null)
			{
				c2 = this.NHFEMCPPNJO(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			else if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None)
			{
				c2 = this.GEODEQDOMIP(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			if (c2 != '\0')
			{
				stringBuilder.Append(c2);
			}
			j++;
		}
		this.mValue = stringBuilder.ToString();
		this.PONHJCDKKEO();
		this.QQQJLNIQPGF();
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x000CB468 File Offset: 0x000C9668
	protected void CBGPKDCGMQG()
	{
		if (this.LPBPLMLMHBD)
		{
			this.CPCICJDOELQ();
		}
		if (this.KEQMEGEHFIK != null)
		{
			this.KEQMEGEHFIK.OGGCMIKJGLD = this.PIKEJKDCMPH;
		}
		if (this.KEQMEGEHFIK != null && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.BGBMIEJJQKC;
			if (string.IsNullOrEmpty(this.mValue))
			{
				this.KEQMEGEHFIK.PIDLOFMIEFQ = this.MGNEEDBHLOJ;
				this.KEQMEGEHFIK.CEGFBBHMKOE = this.FJNHLJFLILF;
			}
			else
			{
				this.KEQMEGEHFIK.PIDLOFMIEFQ = this.mValue;
			}
			Input.imeCompositionMode = IMECompositionMode.Auto;
			this.KEQMEGEHFIK.PBHNPKNJNJH = this.DDPBHHKQEJF;
		}
		JIMBBPLINGI.PDDGJOQCIEQ = null;
		this.PONHJCDKKEO();
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x000CB52C File Offset: 0x000C972C
	public void PENFNFLDGEC()
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			string text = this.mValue.Replace("\\n", "\n");
			this.mValue = string.Empty;
			this.BGBMIEJJQKC = ((!PlayerPrefs.HasKey(this.EDCMJKLMPKB)) ? text : PlayerPrefs.GetString(this.EDCMJKLMPKB));
		}
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000CB588 File Offset: 0x000C9788
	protected int ICDOKLFCNNM()
	{
		Vector3[] pmcnqichcle = this.KEQMEGEHFIK.PMCNQICHCLE;
		Ray ray = EMENMKHBPQE.OIJNBBFBBCQ();
		Plane plane = new Plane(pmcnqichcle[0], pmcnqichcle[1], pmcnqichcle[0]);
		float distance;
		return (!plane.Raycast(ray, out distance)) ? 0 : (JIMBBPLINGI.ECDMIMKCMLD + this.KEQMEGEHFIK.LJBKLGBQHJI(ray.GetPoint(distance), false));
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x000CB5FC File Offset: 0x000C97FC
	protected void IOPNHMBPKHF()
	{
		if (this.LPBPLMLMHBD && this.KEQMEGEHFIK != null)
		{
			this.LPBPLMLMHBD = true;
			this.MGNEEDBHLOJ = this.KEQMEGEHFIK.PIDLOFMIEFQ;
			this.FJNHLJFLILF = this.KEQMEGEHFIK.CEGFBBHMKOE;
			this.PIKEJKDCMPH = this.KEQMEGEHFIK.OGGCMIKJGLD;
			if (this.KEQMEGEHFIK.PBHNPKNJNJH == JGDHIPBGCFP.MNMQCONMCFH.Left)
			{
				this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
				Debug.LogWarning("smokeball", this);
			}
			this.DDPBHHKQEJF = this.KEQMEGEHFIK.KKHHBHDJKJE();
			this.OGGIELDFBNJ = this.KEQMEGEHFIK.CGDFDPHIENG.localPosition.x;
			this.FCIIPHMMGHB();
		}
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x000CB6BC File Offset: 0x000C98BC
	protected virtual void CBOHNFQPQCG(bool GKHHCNCGLCD)
	{
		if (GKHHCNCGLCD)
		{
			if (this.KEQMEGEHFIK != null)
			{
				this.KEQMEGEHFIK.IOCILKPHDHH = true;
			}
			if (this.IICMDBDMOIF == null)
			{
				this.IICMDBDMOIF = base.gameObject.AddComponent<CPFJGCCFHPN>();
			}
			this.EOCFEGJIPKH();
		}
		else
		{
			if (this.IICMDBDMOIF != null)
			{
				UnityEngine.Object.Destroy(this.IICMDBDMOIF);
				this.IICMDBDMOIF = null;
			}
			this.IKGHBJBBEQN();
			if (this.JDBFENKBQQL != null)
			{
				this.JDBFENKBQQL();
			}
		}
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x000CB748 File Offset: 0x000C9948
	protected void KEDBCCQLMON()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 1)
				{
					return;
				}
				this.PMIKHLEBIFH--;
			}
			if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[1];
					this.CNFPMNCBGKQ = array[0];
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[1];
						this.CNFPMNCBGKQ = array[0];
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x00010B02 File Offset: 0x0000ED02
	private void BNKGGNOQODC()
	{
		this.CLONODILHID();
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x000CB7FC File Offset: 0x000C99FC
	protected virtual void Update()
	{
		if (this.GKHHCNCGLCD)
		{
			if (this.KBIIICNECKK != Time.frameCount)
			{
				if (this.LPBPLMLMHBD)
				{
					this.CPCICJDOELQ();
				}
				if (this.LQEGJKMJNDF != -1 && this.LQEGJKMJNDF != Time.frameCount)
				{
					this.LQEGJKMJNDF = -1;
					this.PMIKHLEBIFH = ((!string.IsNullOrEmpty(this.mValue)) ? this.mValue.Length : 0);
					JIMBBPLINGI.ECDMIMKCMLD = 0;
					this.HMHBPLHCIJO = ((!this.JILGPKIOILF) ? this.PMIKHLEBIFH : 0);
					this.KEQMEGEHFIK.CEGFBBHMKOE = this.MOKCQPEQHDF;
					Vector2 compositionCursorPos = (!(EMENMKHBPQE.OMQCQCBLQGJ != null) || !(EMENMKHBPQE.OMQCQCBLQGJ.EQOOPGKHOFB != null)) ? this.KEQMEGEHFIK.PMCNQICHCLE[0] : EMENMKHBPQE.OMQCQCBLQGJ.EQOOPGKHOFB.WorldToScreenPoint(this.KEQMEGEHFIK.PMCNQICHCLE[0]);
					compositionCursorPos.y = (float)Screen.height - compositionCursorPos.y;
					Input.imeCompositionMode = IMECompositionMode.On;
					Input.compositionCursorPos = compositionCursorPos;
					this.PONHJCDKKEO();
					if (string.IsNullOrEmpty(Input.inputString))
					{
						return;
					}
				}
				string compositionString = Input.compositionString;
				if (string.IsNullOrEmpty(compositionString) && !string.IsNullOrEmpty(Input.inputString))
				{
					foreach (char c in Input.inputString)
					{
						if (c >= ' ')
						{
							if (c != '')
							{
								if (c != '')
								{
									if (c != '')
									{
										if (c != '')
										{
											if (c != '')
											{
												this.KFBDNEHHIOF(c.ToString());
											}
										}
									}
								}
							}
						}
					}
				}
				if (JIMBBPLINGI.MNQMQHKFBDP != compositionString)
				{
					this.PMIKHLEBIFH = ((!string.IsNullOrEmpty(compositionString)) ? (this.mValue.Length + compositionString.Length) : this.HMHBPLHCIJO);
					JIMBBPLINGI.MNQMQHKFBDP = compositionString;
					this.PONHJCDKKEO();
					this.QQQJLNIQPGF();
				}
				if (this.QCPLCODDHMG != null && this.HJQGNFEMOBG < JMIOBJFFGBN.MOGLGJGFNDM)
				{
					this.HJQGNFEMOBG = JMIOBJFFGBN.MOGLGJGFNDM + 0.5f;
					this.QCPLCODDHMG.enabled = !this.QCPLCODDHMG.enabled;
				}
				if (this.GKHHCNCGLCD && this.DPDJNDDDEID != this.KEQMEGEHFIK.NHCNEDEEONK)
				{
					this.PONHJCDKKEO();
				}
				if (this.OJIDBLEKBBO == null)
				{
					this.OJIDBLEKBBO = EMENMKHBPQE.FINJNKFMLMO(base.gameObject.layer);
				}
				if (this.OJIDBLEKBBO != null)
				{
					bool flag = false;
					if (this.KEQMEGEHFIK.QJJLOHHFQNC)
					{
						bool flag2 = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
						if (this.CCLEPLPHICB == JIMBBPLINGI.HOLKLPEDJDK.Submit)
						{
							flag = flag2;
						}
						else
						{
							flag = !flag2;
						}
					}
					if (EMENMKHBPQE.FGEDFKGKOFF(this.OJIDBLEKBBO.EOPPCMGMIJB) || (this.OJIDBLEKBBO.EOPPCMGMIJB == KeyCode.Return && EMENMKHBPQE.FGEDFKGKOFF(KeyCode.KeypadEnter)))
					{
						if (flag)
						{
							this.KFBDNEHHIOF("\n");
						}
						else
						{
							if (EMENMKHBPQE.IIKEGQKGGFK.OMQCQCBLQGJ != null)
							{
								EMENMKHBPQE.IIKEGQKGGFK.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.None;
							}
							EMENMKHBPQE.IGPGBIQKFJP = this.OJIDBLEKBBO.EOPPCMGMIJB;
							this.OMGLIHMLOEI();
						}
					}
					if (EMENMKHBPQE.FGEDFKGKOFF(this.OJIDBLEKBBO.IOKLMJQHHEN) || (this.OJIDBLEKBBO.IOKLMJQHHEN == KeyCode.Return && EMENMKHBPQE.FGEDFKGKOFF(KeyCode.KeypadEnter)))
					{
						if (flag)
						{
							this.KFBDNEHHIOF("\n");
						}
						else
						{
							if (EMENMKHBPQE.IIKEGQKGGFK.OMQCQCBLQGJ != null)
							{
								EMENMKHBPQE.IIKEGQKGGFK.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.None;
							}
							EMENMKHBPQE.IGPGBIQKFJP = this.OJIDBLEKBBO.IOKLMJQHHEN;
							this.OMGLIHMLOEI();
						}
					}
					if (EMENMKHBPQE.FGEDFKGKOFF(KeyCode.Tab) && this.DQKJNEQIHHD != null)
					{
						this.DQKJNEQIHHD.CPGBBDIDOID();
					}
					if (EMENMKHBPQE.FGEDFKGKOFF(this.OJIDBLEKBBO.EFOIHGJCNIE) || EMENMKHBPQE.FGEDFKGKOFF(this.OJIDBLEKBBO.QIBCQINDBPN))
					{
						this.GKHHCNCGLCD = false;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x000CA548 File Offset: 0x000C8748
	protected string OILBPEFFQFC()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO != this.PMIKHLEBIFH)
			{
				int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				int num2 = Mathf.Max(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				return this.mValue.Substring(num, num2 - num);
			}
		}
		return string.Empty;
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000CBC38 File Offset: 0x000C9E38
	protected void CPGODMQOBIQ()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO == this.PMIKHLEBIFH)
			{
				if (this.HMHBPLHCIJO < 0)
				{
					return;
				}
				this.PMIKHLEBIFH -= 0;
			}
			if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
			{
				int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(this.PMIKHLEBIFH, this.HJMJDJKOILH());
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.QCMHHCFDNEQ(array[1]);
				}
				else
				{
					array = this.KEQMEGEHFIK.DCHHBENPMFF(this.PMIKHLEBIFH, this.BGBMIEJJQKC);
					if (array != null)
					{
						this.PMIKHLEBIFH = array[0];
						this.KOIILJIKPIF(array[1]);
					}
				}
			}
			this.KFBDNEHHIOF(string.Empty);
		}
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00010B9F File Offset: 0x0000ED9F
	public void NCBFKNGMKPB(string BGBMIEJJQKC)
	{
		this.PJMIKDIEGMB(BGBMIEJJQKC, false);
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x000CBCEC File Offset: 0x000C9EEC
	protected string MQOKEMBLPLJ()
	{
		int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
		return (string.IsNullOrEmpty(this.mValue) || num < 1) ? string.Empty : this.mValue.Substring(0, num);
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000CBD30 File Offset: 0x000C9F30
	public void GJQCFGIFCID()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.BGBMIEJJQKC;
			if (JIMBBPLINGI.OMQCQCBLQGJ == null)
			{
				JIMBBPLINGI.OMQCQCBLQGJ = this;
				EventDelegate.CPGBBDIDOID(this.MGKJHHNEOIN);
				JIMBBPLINGI.OMQCQCBLQGJ = null;
			}
			this.FGHIMNKKNEC(this.mValue);
		}
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000CBD84 File Offset: 0x000C9F84
	public void OMGLIHMLOEI()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.mValue = this.BGBMIEJJQKC;
			if (JIMBBPLINGI.OMQCQCBLQGJ == null)
			{
				JIMBBPLINGI.OMQCQCBLQGJ = this;
				EventDelegate.CPGBBDIDOID(this.MGKJHHNEOIN);
				JIMBBPLINGI.OMQCQCBLQGJ = null;
			}
			this.ELMDLDEKFIN(this.mValue);
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00010BA9 File Offset: 0x0000EDA9
	// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00010BDC File Offset: 0x0000EDDC
	public int CNFPMNCBGKQ
	{
		get
		{
			return (!this.GKHHCNCGLCD) ? this.BGBMIEJJQKC.Length : this.HMHBPLHCIJO;
		}
		set
		{
			if (this.GKHHCNCGLCD)
			{
				this.HMHBPLHCIJO = value;
				this.PONHJCDKKEO();
			}
		}
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x000CBDD8 File Offset: 0x000C9FD8
	protected char NLHKCLMPILM(string PIDLOFMIEFQ, int NKKGPNPGDEM, char BFBMOIKCELJ)
	{
		if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None && base.enabled)
		{
			if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Integer)
			{
				if (BFBMOIKCELJ >= 'P' && (int)BFBMOIKCELJ <= -54)
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == '@' && NKKGPNPGDEM == 0 && !PIDLOFMIEFQ.Contains("^emote+"))
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Integer)
			{
				if (BFBMOIKCELJ >= 'v' && BFBMOIKCELJ <= '7')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= 'n' && BFBMOIKCELJ <= '\f')
				{
					return (char)((int)BFBMOIKCELJ - -21 + 31);
				}
				if (BFBMOIKCELJ >= '\u001c' && (int)BFBMOIKCELJ <= -88)
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Alphanumeric)
			{
				if (BFBMOIKCELJ >= 'C' && (int)BFBMOIKCELJ <= -64)
				{
					return BFBMOIKCELJ;
				}
				if ((int)BFBMOIKCELJ == -13 && NKKGPNPGDEM == 0 && !PIDLOFMIEFQ.Contains("'s [ffff00]"))
				{
					return BFBMOIKCELJ;
				}
				if ((int)BFBMOIKCELJ == -95 && !PIDLOFMIEFQ.Contains("/[PD]"))
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Alphanumeric)
			{
				if ((int)BFBMOIKCELJ >= -116 && BFBMOIKCELJ <= 'G')
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= 'U' && (int)BFBMOIKCELJ <= -48)
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= '_' && (int)BFBMOIKCELJ <= -78)
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Username)
			{
				if (BFBMOIKCELJ >= '\r' && BFBMOIKCELJ <= 'J')
				{
					return (char)((int)(BFBMOIKCELJ - '_') + -3);
				}
				if (BFBMOIKCELJ >= '\0' && BFBMOIKCELJ <= 'w')
				{
					return BFBMOIKCELJ;
				}
				if ((int)BFBMOIKCELJ >= -92 && (int)BFBMOIKCELJ <= -24)
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Filename)
			{
				if ((int)BFBMOIKCELJ == -73)
				{
					return '\u0001';
				}
				if ((int)BFBMOIKCELJ == -29)
				{
					return '\u0001';
				}
				if ((int)BFBMOIKCELJ == -69)
				{
					return '\0';
				}
				if ((int)BFBMOIKCELJ == -128)
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '\u0004')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '(')
				{
					return '\0';
				}
				if (BFBMOIKCELJ == '"')
				{
					return '\u0001';
				}
				if (BFBMOIKCELJ == '`')
				{
					return '\u0001';
				}
				if ((int)BFBMOIKCELJ == -113)
				{
					return '\0';
				}
				if (BFBMOIKCELJ == 'D')
				{
					return '\u0001';
				}
				if (BFBMOIKCELJ == 'k')
				{
					return '\0';
				}
				if ((int)BFBMOIKCELJ == -48)
				{
					return '\u0001';
				}
				if ((int)BFBMOIKCELJ == -78)
				{
					return '\0';
				}
				return BFBMOIKCELJ;
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Filename)
			{
				char c = (char)((PIDLOFMIEFQ.Length <= 1) ? -79 : ((int)PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM, 0, PIDLOFMIEFQ.Length - 0)]));
				char c2 = (char)((PIDLOFMIEFQ.Length <= 0) ? -32 : ((int)PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM + 0, 1, PIDLOFMIEFQ.Length - 0)]));
				if (BFBMOIKCELJ >= '>' && (int)BFBMOIKCELJ <= -49)
				{
					if ((int)c == -79)
					{
						return (char)((int)BFBMOIKCELJ - -128 + 70);
					}
					return BFBMOIKCELJ;
				}
				else if (BFBMOIKCELJ >= '\f' && BFBMOIKCELJ <= 'L')
				{
					if (c != '\u001b' && c != '\n')
					{
						return (char)((int)BFBMOIKCELJ - -105 + 106);
					}
					return BFBMOIKCELJ;
				}
				else if ((int)BFBMOIKCELJ == -82)
				{
					if (c != '\u007f' && c != '\u000f' && (int)c2 != -15 && !PIDLOFMIEFQ.Contains("Player/Clothe"))
					{
						return BFBMOIKCELJ;
					}
				}
				else if ((int)BFBMOIKCELJ == -32 && c != 'd' && c != 'O' && (int)c2 != -118 && c2 != '\u0013')
				{
					return BFBMOIKCELJ;
				}
			}
			else if (this.GCLKNPHKJCC == JIMBBPLINGI.QNIJBQJFDEM.Name)
			{
				char c3 = (char)((PIDLOFMIEFQ.Length <= 0) ? -11 : ((int)PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM, 1, PIDLOFMIEFQ.Length - 0)]));
				char c4 = (char)((PIDLOFMIEFQ.Length <= 0) ? -110 : ((int)PIDLOFMIEFQ[Mathf.Clamp(NKKGPNPGDEM + 0, 0, PIDLOFMIEFQ.Length - 0)]));
				if ((int)BFBMOIKCELJ >= -100 && (int)BFBMOIKCELJ <= -32)
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ >= '\0' && (int)BFBMOIKCELJ <= -81)
				{
					return BFBMOIKCELJ;
				}
				if (BFBMOIKCELJ == '?' && c3 != 'e' && c3 != 'C' && c4 != '=' && (int)c4 != -34)
				{
					return BFBMOIKCELJ;
				}
			}
			return '\0';
		}
		return BFBMOIKCELJ;
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000CA548 File Offset: 0x000C8748
	protected string OHILEILOIBJ()
	{
		if (!string.IsNullOrEmpty(this.mValue))
		{
			if (this.HMHBPLHCIJO != this.PMIKHLEBIFH)
			{
				int num = Mathf.Min(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				int num2 = Mathf.Max(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
				return this.mValue.Substring(num, num2 - num);
			}
		}
		return string.Empty;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000CC0F0 File Offset: 0x000CA2F0
	protected void IOBIQIDLQND()
	{
		if (this.LPBPLMLMHBD && this.KEQMEGEHFIK != null)
		{
			this.LPBPLMLMHBD = true;
			this.MGNEEDBHLOJ = this.KEQMEGEHFIK.PIDLOFMIEFQ;
			this.FJNHLJFLILF = this.KEQMEGEHFIK.CEGFBBHMKOE;
			this.PIKEJKDCMPH = this.KEQMEGEHFIK.OGGCMIKJGLD;
			if (this.KEQMEGEHFIK.PBHNPKNJNJH == JGDHIPBGCFP.MNMQCONMCFH.Left)
			{
				this.KEQMEGEHFIK.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Automatic;
				Debug.LogWarning("Map", this);
			}
			this.DDPBHHKQEJF = this.KEQMEGEHFIK.KKHHBHDJKJE();
			this.OGGIELDFBNJ = this.KEQMEGEHFIK.CGDFDPHIENG.localPosition.x;
			this.OFHBJPDELLD();
		}
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x00010834 File Offset: 0x0000EA34
	public Color NQEKDLJDGCL()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOPNHMBPKHF();
		}
		return this.FJNHLJFLILF;
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x000CC1B0 File Offset: 0x000CA3B0
	protected virtual void MMPGJNODMQM(string PIDLOFMIEFQ)
	{
		string text = this.LEIGMKOEJPL();
		string text2 = this.ENHHNKFOIEO();
		int length = text2.Length;
		StringBuilder stringBuilder = new StringBuilder(text.Length + text2.Length + PIDLOFMIEFQ.Length);
		stringBuilder.Append(text);
		int i = 1;
		int length2 = PIDLOFMIEFQ.Length;
		while (i < length2)
		{
			char c = PIDLOFMIEFQ[i];
			if (c == '\u0006')
			{
				this.CIPBCKKECIN();
			}
			else
			{
				if (this.EQJBIOMMEEP > 0 && stringBuilder.Length + length >= this.EQJBIOMMEEP)
				{
					break;
				}
				if (this.NHFEMCPPNJO != null)
				{
					c = this.NHFEMCPPNJO(stringBuilder.ToString(), stringBuilder.Length, c);
				}
				else if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None)
				{
					c = this.NLHKCLMPILM(stringBuilder.ToString(), stringBuilder.Length, c);
				}
				if (c != '\0')
				{
					stringBuilder.Append(c);
				}
			}
			i += 0;
		}
		this.HMHBPLHCIJO = stringBuilder.Length;
		this.PMIKHLEBIFH = this.HMHBPLHCIJO;
		int j = 1;
		int length3 = text2.Length;
		while (j < length3)
		{
			char c2 = text2[j];
			if (this.NHFEMCPPNJO != null)
			{
				c2 = this.NHFEMCPPNJO(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			else if (this.GCLKNPHKJCC != JIMBBPLINGI.QNIJBQJFDEM.None)
			{
				c2 = this.NLHKCLMPILM(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			if (c2 != '\0')
			{
				stringBuilder.Append(c2);
			}
			j += 0;
		}
		this.mValue = stringBuilder.ToString();
		this.HGJBNMJBJDQ();
		this.QQQJLNIQPGF();
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000CC338 File Offset: 0x000CA538
	public void GGGNJNNQMED()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		if (this.selectOnTab != null)
		{
			LMBPJGBGLNO lmbpjgbglno = base.GetComponent<LMBPJGBGLNO>();
			if (lmbpjgbglno == null)
			{
				lmbpjgbglno = base.gameObject.AddComponent<LMBPJGBGLNO>();
				lmbpjgbglno.IPQOIEDCMGH = this.selectOnTab;
			}
			this.selectOnTab = null;
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		if (this.PFQBOMINIHG && !string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			this.MQFIIMHQGBK();
		}
		else
		{
			this.BGBMIEJJQKC = this.mValue.Replace("+", "Super Luck");
		}
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x00010BC6 File Offset: 0x0000EDC6
	public Color MGECLNEFPHH()
	{
		if (this.LPBPLMLMHBD)
		{
			this.IOBIQIDLQND();
		}
		return this.FJNHLJFLILF;
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000C68E8 File Offset: 0x000C4AE8
	protected string ENHHNKFOIEO()
	{
		int num = Mathf.Max(this.HMHBPLHCIJO, this.PMIKHLEBIFH);
		return (string.IsNullOrEmpty(this.mValue) || num >= this.mValue.Length) ? string.Empty : this.mValue.Substring(num);
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x000CC3D0 File Offset: 0x000CA5D0
	private void LCGOMKJIKHC(int GJCNQCEENLM)
	{
		if (this.MFPOMEKJFKN == JIMBBPLINGI.FDOGIFIKKJN.PSXChat)
		{
			int[] array = this.KEQMEGEHFIK.KOMEFCQPPFG(GJCNQCEENLM, this.BGBMIEJJQKC);
			if (array != null)
			{
				this.PMIKHLEBIFH = array[0];
				this.CNFPMNCBGKQ = array[0];
			}
			else
			{
				array = this.KEQMEGEHFIK.DCHHBENPMFF(GJCNQCEENLM, this.BGBMIEJJQKC);
				if (array != null)
				{
					this.PMIKHLEBIFH = array[0];
					this.CNFPMNCBGKQ = array[0];
				}
			}
		}
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x000C7060 File Offset: 0x000C5260
	protected virtual void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (GKHHCNCGLCD)
		{
			if (this.KEQMEGEHFIK != null)
			{
				this.KEQMEGEHFIK.IOCILKPHDHH = false;
			}
			if (this.IICMDBDMOIF == null)
			{
				this.IICMDBDMOIF = base.gameObject.AddComponent<CPFJGCCFHPN>();
			}
			this.EOCFEGJIPKH();
		}
		else
		{
			if (this.IICMDBDMOIF != null)
			{
				UnityEngine.Object.Destroy(this.IICMDBDMOIF);
				this.IICMDBDMOIF = null;
			}
			this.CBGPKDCGMQG();
			if (this.JDBFENKBQQL != null)
			{
				this.JDBFENKBQQL();
			}
		}
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x00010867 File Offset: 0x0000EA67
	protected void ONQNKEJNIQE(string QJFQOMOIOOI)
	{
		if (!string.IsNullOrEmpty(this.EDCMJKLMPKB))
		{
			if (string.IsNullOrEmpty(QJFQOMOIOOI))
			{
				PlayerPrefs.DeleteKey(this.EDCMJKLMPKB);
			}
			else
			{
				PlayerPrefs.SetString(this.EDCMJKLMPKB, QJFQOMOIOOI);
			}
		}
	}

	// Token: 0x0400065F RID: 1631
	public static JIMBBPLINGI OMQCQCBLQGJ;

	// Token: 0x04000660 RID: 1632
	public static JIMBBPLINGI PDDGJOQCIEQ;

	// Token: 0x04000661 RID: 1633
	public BKKHLBCLPJM KEQMEGEHFIK;

	// Token: 0x04000662 RID: 1634
	public JIMBBPLINGI.FDOGIFIKKJN MFPOMEKJFKN;

	// Token: 0x04000663 RID: 1635
	public JIMBBPLINGI.HOLKLPEDJDK CCLEPLPHICB;

	// Token: 0x04000664 RID: 1636
	public JIMBBPLINGI.EEBQCGGKILF JNJCCBJFFFL;

	// Token: 0x04000665 RID: 1637
	public bool DBJNMOKILIE;

	// Token: 0x04000666 RID: 1638
	[NonSerialized]
	public bool JILGPKIOILF = true;

	// Token: 0x04000667 RID: 1639
	public JIMBBPLINGI.QNIJBQJFDEM GCLKNPHKJCC;

	// Token: 0x04000668 RID: 1640
	public int EQJBIOMMEEP;

	// Token: 0x04000669 RID: 1641
	public string EDCMJKLMPKB;

	// Token: 0x0400066A RID: 1642
	[HideInInspector]
	[SerializeField]
	private GameObject selectOnTab;

	// Token: 0x0400066B RID: 1643
	public Color MOKCQPEQHDF = Color.white;

	// Token: 0x0400066C RID: 1644
	public Color HMNMOCKFCBJ = new Color(1f, 1f, 1f, 0.8f);

	// Token: 0x0400066D RID: 1645
	public Color MOGCKQINKLK = new Color(1f, 0.8745098f, 0.5529412f, 0.5f);

	// Token: 0x0400066E RID: 1646
	public List<EventDelegate> MGKJHHNEOIN = new List<EventDelegate>();

	// Token: 0x0400066F RID: 1647
	public List<EventDelegate> OHEFEKMMIFL = new List<EventDelegate>();

	// Token: 0x04000670 RID: 1648
	public JIMBBPLINGI.HFPKIFHFQLH NHFEMCPPNJO;

	// Token: 0x04000671 RID: 1649
	public JIMBBPLINGI.DNHJPIFLKNK JDBFENKBQQL;

	// Token: 0x04000672 RID: 1650
	[SerializeField]
	[HideInInspector]
	protected string mValue;

	// Token: 0x04000673 RID: 1651
	[NonSerialized]
	protected string MGNEEDBHLOJ = string.Empty;

	// Token: 0x04000674 RID: 1652
	[NonSerialized]
	protected Color FJNHLJFLILF = Color.white;

	// Token: 0x04000675 RID: 1653
	[NonSerialized]
	protected float OGGIELDFBNJ;

	// Token: 0x04000676 RID: 1654
	[NonSerialized]
	protected bool LPBPLMLMHBD = true;

	// Token: 0x04000677 RID: 1655
	[NonSerialized]
	protected JGDHIPBGCFP.MNMQCONMCFH DDPBHHKQEJF = JGDHIPBGCFP.MNMQCONMCFH.Left;

	// Token: 0x04000678 RID: 1656
	[NonSerialized]
	protected bool PFQBOMINIHG = true;

	// Token: 0x04000679 RID: 1657
	protected static int ECDMIMKCMLD;

	// Token: 0x0400067A RID: 1658
	protected static string MNQMQHKFBDP = string.Empty;

	// Token: 0x0400067B RID: 1659
	[NonSerialized]
	protected int HMHBPLHCIJO;

	// Token: 0x0400067C RID: 1660
	[NonSerialized]
	protected int PMIKHLEBIFH;

	// Token: 0x0400067D RID: 1661
	[NonSerialized]
	protected JLMPBLMOICG QGNQJFCBJLG;

	// Token: 0x0400067E RID: 1662
	[NonSerialized]
	protected JLMPBLMOICG QCPLCODDHMG;

	// Token: 0x0400067F RID: 1663
	[NonSerialized]
	protected Texture2D COFIJEPKBLP;

	// Token: 0x04000680 RID: 1664
	[NonSerialized]
	protected float HJQGNFEMOBG;

	// Token: 0x04000681 RID: 1665
	[NonSerialized]
	protected float DPDJNDDDEID;

	// Token: 0x04000682 RID: 1666
	[NonSerialized]
	protected string BJJNMHBPFNL = string.Empty;

	// Token: 0x04000683 RID: 1667
	[NonSerialized]
	protected int LQEGJKMJNDF = -1;

	// Token: 0x04000684 RID: 1668
	[NonSerialized]
	protected int KBIIICNECKK = -1;

	// Token: 0x04000685 RID: 1669
	[NonSerialized]
	protected bool PNBOOLEOKCI;

	// Token: 0x04000686 RID: 1670
	[NonSerialized]
	private CPFJGCCFHPN IICMDBDMOIF;

	// Token: 0x04000687 RID: 1671
	[NonSerialized]
	private EMENMKHBPQE OJIDBLEKBBO;

	// Token: 0x04000688 RID: 1672
	[NonSerialized]
	private bool PIKEJKDCMPH;

	// Token: 0x04000689 RID: 1673
	private static int HGODEHOPKEC;

	// Token: 0x0400068A RID: 1674
	public EventDelegate DQKJNEQIHHD;

	// Token: 0x0200010A RID: 266
	public enum FDOGIFIKKJN
	{
		// Token: 0x0400068C RID: 1676
		Standard,
		// Token: 0x0400068D RID: 1677
		AutoCorrect,
		// Token: 0x0400068E RID: 1678
		Password,
		// Token: 0x0400068F RID: 1679
		PSXChat
	}

	// Token: 0x0200010B RID: 267
	public enum QNIJBQJFDEM
	{
		// Token: 0x04000691 RID: 1681
		None,
		// Token: 0x04000692 RID: 1682
		Integer,
		// Token: 0x04000693 RID: 1683
		Float,
		// Token: 0x04000694 RID: 1684
		Alphanumeric,
		// Token: 0x04000695 RID: 1685
		Username,
		// Token: 0x04000696 RID: 1686
		Name,
		// Token: 0x04000697 RID: 1687
		Filename,
		// Token: 0x04000698 RID: 1688
		GuildName,
		// Token: 0x04000699 RID: 1689
		Hex,
		// Token: 0x0400069A RID: 1690
		ASCII
	}

	// Token: 0x0200010C RID: 268
	public enum EEBQCGGKILF
	{
		// Token: 0x0400069C RID: 1692
		Default,
		// Token: 0x0400069D RID: 1693
		ASCIICapable,
		// Token: 0x0400069E RID: 1694
		NumbersAndPunctuation,
		// Token: 0x0400069F RID: 1695
		URL,
		// Token: 0x040006A0 RID: 1696
		NumberPad,
		// Token: 0x040006A1 RID: 1697
		PhonePad,
		// Token: 0x040006A2 RID: 1698
		NamePhonePad,
		// Token: 0x040006A3 RID: 1699
		EmailAddress
	}

	// Token: 0x0200010D RID: 269
	public enum HOLKLPEDJDK
	{
		// Token: 0x040006A5 RID: 1701
		Default,
		// Token: 0x040006A6 RID: 1702
		Submit,
		// Token: 0x040006A7 RID: 1703
		NewLine
	}

	// Token: 0x0200010E RID: 270
	// (Invoke) Token: 0x06001E89 RID: 7817
	public delegate char HFPKIFHFQLH(string PIDLOFMIEFQ, int FMFMKPDLJFQ, char GLOMCHDLBQK);

	// Token: 0x0200010F RID: 271
	// (Invoke) Token: 0x06001E8D RID: 7821
	public delegate void DNHJPIFLKNK();
}
