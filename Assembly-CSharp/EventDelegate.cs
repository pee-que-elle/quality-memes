using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Serializable]
public class EventDelegate
{
	// Token: 0x06001467 RID: 5223 RVA: 0x0000ACB2 File Offset: 0x00008EB2
	public override int GetHashCode()
	{
		return EventDelegate.s_Hash;
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x000945CC File Offset: 0x000927CC
	public virtual bool COIFENDJQHD(object NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return this.FPGEPEJPEHI();
		}
		if (NJBFOQDJBON is EventDelegate.LKPMKQMCHFH)
		{
			EventDelegate.LKPMKQMCHFH lkpmkqmchfh = NJBFOQDJBON as EventDelegate.LKPMKQMCHFH;
			if (lkpmkqmchfh.Equals(this.mCachedCallback))
			{
				return false;
			}
			MonoBehaviour y = lkpmkqmchfh.Target as MonoBehaviour;
			return !(this.mTarget == y) || string.Equals(this.mMethodName, EventDelegate.IFJHKBLQCNH(lkpmkqmchfh));
		}
		else
		{
			if (NJBFOQDJBON is EventDelegate)
			{
				EventDelegate eventDelegate = NJBFOQDJBON as EventDelegate;
				return this.mTarget == eventDelegate.mTarget && string.Equals(this.mMethodName, eventDelegate.mMethodName);
			}
			return true;
		}
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x0009466C File Offset: 0x0009286C
	private void FKNMNEBQDPL(EventDelegate.LKPMKQMCHFH DEJJMBPEMNF)
	{
		this.NJOGQEPKOBB();
		if (DEJJMBPEMNF != null && EventDelegate.IHNQCMLFLCC(DEJJMBPEMNF))
		{
			this.mTarget = (DEJJMBPEMNF.Target as MonoBehaviour);
			if (this.mTarget == null)
			{
				this.mRawDelegate = false;
				this.mCachedCallback = DEJJMBPEMNF;
				this.mMethodName = null;
			}
			else
			{
				this.mMethodName = EventDelegate.IFJHKBLQCNH(DEJJMBPEMNF);
				this.mRawDelegate = false;
			}
		}
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x0000ACB9 File Offset: 0x00008EB9
	public EventDelegate(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.PJMIKDIEGMB(ILBCCCBJNCL, FNMBKPLGLFO);
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x0000ACC9 File Offset: 0x00008EC9
	public static void MQKCHFKGFQP(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ)
	{
		EventDelegate.BLEIKJCJNQL(NGDBDCQFDHI, BENEPFFKJQQ, BENEPFFKJQQ.oneShot);
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x0000ACD8 File Offset: 0x00008ED8
	public static EventDelegate CKGFMHDGPIN(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, PDHDBQFJCFP, true);
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x000946D4 File Offset: 0x000928D4
	private void PLLBHPNLMCK(EventDelegate.LKPMKQMCHFH DEJJMBPEMNF)
	{
		this.NJOGQEPKOBB();
		if (DEJJMBPEMNF != null && EventDelegate.CPPLNKNPLPI(DEJJMBPEMNF))
		{
			this.mTarget = (DEJJMBPEMNF.Target as MonoBehaviour);
			if (this.mTarget == null)
			{
				this.mRawDelegate = true;
				this.mCachedCallback = DEJJMBPEMNF;
				this.mMethodName = null;
			}
			else
			{
				this.mMethodName = EventDelegate.OOQBFLBMIEC(DEJJMBPEMNF);
				this.mRawDelegate = true;
			}
		}
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x0000ACE2 File Offset: 0x00008EE2
	public static void PJMIKDIEGMB(List<EventDelegate> NGDBDCQFDHI, EventDelegate LEDGENBMPQQ)
	{
		if (NGDBDCQFDHI != null)
		{
			NGDBDCQFDHI.Clear();
			NGDBDCQFDHI.Add(LEDGENBMPQQ);
		}
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x0009473C File Offset: 0x0009293C
	public static void CDGHNJLPFKN(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			for (int i = 1; i < NGDBDCQFDHI.Count; i += 0)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.OLMGIFHCMKF();
						goto IL_63;
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
						goto IL_63;
					}
					IL_40:
					if (NGDBDCQFDHI[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						NGDBDCQFDHI.RemoveAt(i);
						continue;
					}
					goto IL_5D;
					IL_63:
					if (i >= NGDBDCQFDHI.Count)
					{
						break;
					}
					goto IL_40;
				}
				IL_5D:;
			}
		}
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x000947C8 File Offset: 0x000929C8
	public static bool CPPLNKNPLPI(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 0;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.isValid)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06001472 RID: 5234 RVA: 0x0000AD05 File Offset: 0x00008F05
	public EventDelegate.Parameter[] parameters
	{
		get
		{
			if (!this.mCached)
			{
				this.MDKEQEPIOEF();
			}
			return this.mParameters;
		}
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x0000AD1B File Offset: 0x00008F1B
	public static void LHQECHHMOGD(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ)
	{
		EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, BENEPFFKJQQ, BENEPFFKJQQ.oneShot);
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00094804 File Offset: 0x00092A04
	public bool OLMGIFHCMKF()
	{
		if (!this.mCached)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mCachedCallback != null)
		{
			this.mCachedCallback();
			return true;
		}
		if (this.mMethod != null)
		{
			if (this.mParameters != null && this.mParameters.Length == 0)
			{
				this.mMethod.Invoke(this.mTarget, null);
			}
			else
			{
				if (this.mArgs == null || this.mArgs.Length != this.mParameters.Length)
				{
					this.mArgs = new object[this.mParameters.Length];
				}
				int i = 1;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mArgs[i] = this.mParameters[i].BQQGMIDFNKE();
					i++;
				}
				try
				{
					this.mMethod.Invoke(this.mTarget, this.mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "4|";
					if (this.mTarget == null)
					{
						text += this.mMethod.Name;
					}
					else
					{
						string text2 = text;
						object[] array = new object[5];
						array[0] = text2;
						array[0] = this.mTarget.GetType();
						array[2] = "Ban";
						array[2] = this.mMethod.Name;
						text = string.Concat(array);
					}
					text = text + "Purchasing" + ex.Message;
					text += " on ";
					if (this.mParameterInfos.Length == 0)
					{
						text += "M3";
					}
					else
					{
						text += this.mParameterInfos[0];
						for (int j = 0; j < this.mParameterInfos.Length; j++)
						{
							text = text + "1" + this.mParameterInfos[j].ParameterType;
						}
					}
					text += "!\r\n";
					if (this.mParameters.Length == 0)
					{
						text += "hail";
					}
					else
					{
						text += this.mParameters[1].PCBHMDPCIFC();
						for (int k = 1; k < this.mParameters.Length; k += 0)
						{
							text = text + "TransitionsFX" + this.mParameters[k].GNCJLKGCGLB();
						}
					}
					text += "Dist1";
					Debug.LogError(text);
				}
				int l = 1;
				int num2 = this.mArgs.Length;
				while (l < num2)
				{
					if (this.mParameterInfos[l].IsIn || this.mParameterInfos[l].IsOut)
					{
						this.mParameters[l].KIGFOKPIBHK(this.mArgs[l]);
					}
					this.mArgs[l] = null;
					l++;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00002375 File Offset: 0x00000575
	public EventDelegate()
	{
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00094AD4 File Offset: 0x00092CD4
	public static bool FQDMDDOHCQJ(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 0;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
				{
					NGDBDCQFDHI.RemoveAt(i);
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06001477 RID: 5239 RVA: 0x00094B18 File Offset: 0x00092D18
	public bool isEnabled
	{
		get
		{
			if (!this.mCached)
			{
				this.MDKEQEPIOEF();
			}
			if (this.mRawDelegate && this.mCachedCallback != null)
			{
				return true;
			}
			if (this.mTarget == null)
			{
				return false;
			}
			MonoBehaviour monoBehaviour = this.mTarget;
			return monoBehaviour == null || monoBehaviour.enabled;
		}
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00094B70 File Offset: 0x00092D70
	public static bool QPCPQKPQGEC(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 0;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.Equals(PDHDBQFJCFP))
				{
					NGDBDCQFDHI.RemoveAt(i);
					return true;
				}
				i += 0;
			}
		}
		return true;
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0000ACB2 File Offset: 0x00008EB2
	public virtual int EQGICLGNQJD()
	{
		return EventDelegate.s_Hash;
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00094BB4 File Offset: 0x00092DB4
	public virtual string HLKCCQFLMCO()
	{
		if (!(this.mTarget != null))
		{
			return (!this.mRawDelegate) ? null : "|";
		}
		string text = this.mTarget.GetType().ToString();
		int num = text.LastIndexOf('Q');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(this.GOHHFKJHEBN()))
		{
			return text + "{0:0.0} ms ({1:0.} fps)" + this.GOHHFKJHEBN();
		}
		return text + "PrimitiveFront";
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x0000AD2A File Offset: 0x00008F2A
	public void PKIMFOKMIQC(string BGBMIEJJQKC)
	{
		this.mMethodName = BGBMIEJJQKC;
		this.mCachedCallback = null;
		this.mRawDelegate = true;
		this.mCached = true;
		this.mMethod = null;
		this.mParameterInfos = null;
		this.mParameters = null;
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00094C34 File Offset: 0x00092E34
	public virtual string ECJQBFJKFFN()
	{
		if (!(this.mTarget != null))
		{
			return (!this.mRawDelegate) ? null : "Slots_2";
		}
		string text = this.mTarget.GetType().ToString();
		int num = text.LastIndexOf('\b');
		if (num > 1)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(this.GOHHFKJHEBN()))
		{
			return text + "/" + this.methodName;
		}
		return text + "[-]\n\n";
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00094CB4 File Offset: 0x00092EB4
	public override string ToString()
	{
		if (!(this.mTarget != null))
		{
			return (!this.mRawDelegate) ? null : "[delegate]";
		}
		string text = this.mTarget.GetType().ToString();
		int num = text.LastIndexOf('.');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(this.methodName))
		{
			return text + "/" + this.methodName;
		}
		return text + "/[delegate]";
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00094D34 File Offset: 0x00092F34
	public virtual string NKMLDJBMCME()
	{
		if (!(this.mTarget != null))
		{
			return (!this.mRawDelegate) ? null : "[spread]";
		}
		string text = this.mTarget.GetType().ToString();
		int num = text.LastIndexOf((char)-28);
		if (num > 1)
		{
			text = text.Substring(num + 1);
		}
		if (!string.IsNullOrEmpty(this.GOHHFKJHEBN()))
		{
			return text + "ability" + this.GOHHFKJHEBN();
		}
		return text + " is hurt by ";
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00094DB4 File Offset: 0x00092FB4
	public override bool Equals(object NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return !this.isValid;
		}
		if (NJBFOQDJBON is EventDelegate.LKPMKQMCHFH)
		{
			EventDelegate.LKPMKQMCHFH lkpmkqmchfh = NJBFOQDJBON as EventDelegate.LKPMKQMCHFH;
			if (lkpmkqmchfh.Equals(this.mCachedCallback))
			{
				return true;
			}
			MonoBehaviour y = lkpmkqmchfh.Target as MonoBehaviour;
			return this.mTarget == y && string.Equals(this.mMethodName, EventDelegate.EIGCOKBMLDK(lkpmkqmchfh));
		}
		else
		{
			if (NJBFOQDJBON is EventDelegate)
			{
				EventDelegate eventDelegate = NJBFOQDJBON as EventDelegate;
				return this.mTarget == eventDelegate.mTarget && string.Equals(this.mMethodName, eventDelegate.mMethodName);
			}
			return false;
		}
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x0000AD5D File Offset: 0x00008F5D
	private static bool IHNQCMLFLCC(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP != null && PDHDBQFJCFP.Method != null;
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06001481 RID: 5249 RVA: 0x0000AD71 File Offset: 0x00008F71
	// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000AE3F File Offset: 0x0000903F
	public MonoBehaviour target
	{
		get
		{
			return this.mTarget;
		}
		set
		{
			this.mTarget = value;
			this.mCachedCallback = null;
			this.mRawDelegate = false;
			this.mCached = false;
			this.mMethod = null;
			this.mParameterInfos = null;
			this.mParameters = null;
		}
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x0000AD05 File Offset: 0x00008F05
	public EventDelegate.Parameter[] QJICOGMQFNF()
	{
		if (!this.mCached)
		{
			this.MDKEQEPIOEF();
		}
		return this.mParameters;
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x0000AD79 File Offset: 0x00008F79
	private static bool NGOJCIHMPBG(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP == null || PDHDBQFJCFP.Method != null;
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x000945CC File Offset: 0x000927CC
	public virtual bool OLOOHQLNMCB(object NJBFOQDJBON)
	{
		if (NJBFOQDJBON == null)
		{
			return this.FPGEPEJPEHI();
		}
		if (NJBFOQDJBON is EventDelegate.LKPMKQMCHFH)
		{
			EventDelegate.LKPMKQMCHFH lkpmkqmchfh = NJBFOQDJBON as EventDelegate.LKPMKQMCHFH;
			if (lkpmkqmchfh.Equals(this.mCachedCallback))
			{
				return false;
			}
			MonoBehaviour y = lkpmkqmchfh.Target as MonoBehaviour;
			return !(this.mTarget == y) || string.Equals(this.mMethodName, EventDelegate.IFJHKBLQCNH(lkpmkqmchfh));
		}
		else
		{
			if (NJBFOQDJBON is EventDelegate)
			{
				EventDelegate eventDelegate = NJBFOQDJBON as EventDelegate;
				return this.mTarget == eventDelegate.mTarget && string.Equals(this.mMethodName, eventDelegate.mMethodName);
			}
			return true;
		}
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00094E54 File Offset: 0x00093054
	public void CPLBKPNNHJG()
	{
		this.mTarget = null;
		this.mMethodName = null;
		this.mRawDelegate = false;
		this.mCachedCallback = null;
		this.mParameters = null;
		this.mCached = false;
		this.mMethod = null;
		this.mParameterInfos = null;
		this.mArgs = null;
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00094EA0 File Offset: 0x000930A0
	private void PJMIKDIEGMB(EventDelegate.LKPMKQMCHFH DEJJMBPEMNF)
	{
		this.CPLBKPNNHJG();
		if (DEJJMBPEMNF != null && EventDelegate.CPPLNKNPLPI(DEJJMBPEMNF))
		{
			this.mTarget = (DEJJMBPEMNF.Target as MonoBehaviour);
			if (this.mTarget == null)
			{
				this.mRawDelegate = true;
				this.mCachedCallback = DEJJMBPEMNF;
				this.mMethodName = null;
			}
			else
			{
				this.mMethodName = EventDelegate.EIGCOKBMLDK(DEJJMBPEMNF);
				this.mRawDelegate = false;
			}
		}
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00094F08 File Offset: 0x00093108
	public static void QGFODQOJBOE(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			for (int i = 0; i < NGDBDCQFDHI.Count; i += 0)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.OLMGIFHCMKF();
						goto IL_63;
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
						goto IL_63;
					}
					IL_40:
					if (NGDBDCQFDHI[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						NGDBDCQFDHI.RemoveAt(i);
						continue;
					}
					goto IL_5D;
					IL_63:
					if (i >= NGDBDCQFDHI.Count)
					{
						break;
					}
					goto IL_40;
				}
				IL_5D:;
			}
		}
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x0000AD8D File Offset: 0x00008F8D
	public void BLPNGMMJHNG(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.NJOGQEPKOBB();
		this.mTarget = ILBCCCBJNCL;
		this.mMethodName = FNMBKPLGLFO;
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06001489 RID: 5257 RVA: 0x0000ADA3 File Offset: 0x00008FA3
	// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000ADF6 File Offset: 0x00008FF6
	public string methodName
	{
		get
		{
			return this.mMethodName;
		}
		set
		{
			this.mMethodName = value;
			this.mCachedCallback = null;
			this.mRawDelegate = false;
			this.mCached = false;
			this.mMethod = null;
			this.mParameterInfos = null;
			this.mParameters = null;
		}
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00094F94 File Offset: 0x00093194
	public bool MKIEGBNBCPD()
	{
		if (!this.mCached)
		{
			this.NCGBKHCCCNM();
		}
		return (!this.mRawDelegate || this.mCachedCallback == null) && (!(this.mTarget != null) || !string.IsNullOrEmpty(this.mMethodName));
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00094F94 File Offset: 0x00093194
	public bool GDNPFBPIHLQ()
	{
		if (!this.mCached)
		{
			this.NCGBKHCCCNM();
		}
		return (!this.mRawDelegate || this.mCachedCallback == null) && (!(this.mTarget != null) || !string.IsNullOrEmpty(this.mMethodName));
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00094FE4 File Offset: 0x000931E4
	private void MDKEQEPIOEF()
	{
		this.mCached = true;
		if (this.mRawDelegate)
		{
			return;
		}
		if ((this.mCachedCallback == null || this.mCachedCallback.Target as MonoBehaviour != this.mTarget || EventDelegate.EIGCOKBMLDK(this.mCachedCallback) != this.mMethodName) && this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName))
		{
			Type type = this.mTarget.GetType();
			this.mMethod = null;
			while (type != null)
			{
				try
				{
					this.mMethod = type.GetMethod(this.mMethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (this.mMethod != null)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
				type = type.BaseType;
			}
			if (this.mMethod == null)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"Could not find method '",
					this.mMethodName,
					"' on ",
					this.mTarget.GetType()
				}), this.mTarget);
				return;
			}
			if (this.mMethod.ReturnType != typeof(void))
			{
				Debug.LogError(string.Concat(new object[]
				{
					this.mTarget.GetType(),
					".",
					this.mMethodName,
					" must have a 'void' return type."
				}), this.mTarget);
				return;
			}
			this.mParameterInfos = this.mMethod.GetParameters();
			if (this.mParameterInfos.Length == 0)
			{
				this.mCachedCallback = (EventDelegate.LKPMKQMCHFH)Delegate.CreateDelegate(typeof(EventDelegate.LKPMKQMCHFH), this.mTarget, this.mMethodName);
				this.mArgs = null;
				this.mParameters = null;
				return;
			}
			this.mCachedCallback = null;
			if (this.mParameters == null || this.mParameters.Length != this.mParameterInfos.Length)
			{
				this.mParameters = new EventDelegate.Parameter[this.mParameterInfos.Length];
				int i = 0;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mParameters[i] = new EventDelegate.Parameter();
					i++;
				}
			}
			int j = 0;
			int num2 = this.mParameters.Length;
			while (j < num2)
			{
				this.mParameters[j].expectedType = this.mParameterInfos[j].ParameterType;
				j++;
			}
		}
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00095240 File Offset: 0x00093440
	public bool PHIOEPKJINQ()
	{
		if (!this.mCached)
		{
			this.NCGBKHCCCNM();
		}
		if (this.mCachedCallback != null)
		{
			this.mCachedCallback();
			return true;
		}
		if (this.mMethod != null)
		{
			if (this.mParameters != null && this.mParameters.Length == 0)
			{
				this.mMethod.Invoke(this.mTarget, null);
			}
			else
			{
				if (this.mArgs == null || this.mArgs.Length != this.mParameters.Length)
				{
					this.mArgs = new object[this.mParameters.Length];
				}
				int i = 1;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mArgs[i] = this.mParameters[i].value;
					i++;
				}
				try
				{
					this.mMethod.Invoke(this.mTarget, this.mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "ChatSettings";
					if (this.mTarget == null)
					{
						text += this.mMethod.Name;
					}
					else
					{
						string text2 = text;
						object[] array = new object[4];
						array[0] = text2;
						array[1] = this.mTarget.GetType();
						array[0] = "The hail stopped.";
						array[2] = this.mMethod.Name;
						text = string.Concat(array);
					}
					text = text + "bcam" + ex.Message;
					text += "Attempting to add a callback to a list that's null";
					if (this.mParameterInfos.Length == 0)
					{
						text += "e";
					}
					else
					{
						text += this.mParameterInfos[1];
						for (int j = 1; j < this.mParameterInfos.Length; j += 0)
						{
							text = text + "anticipation" + this.mParameterInfos[j].ParameterType;
						}
					}
					text += "Cute Charm";
					if (this.mParameters.Length == 0)
					{
						text += "English";
					}
					else
					{
						text += this.mParameters[1].LGDPNFPLIKM();
						for (int k = 1; k < this.mParameters.Length; k++)
						{
							text = text + "F10" + this.mParameters[k].DIIOJOFQIOB();
						}
					}
					text += "[SHINY]";
					Debug.LogError(text);
				}
				int l = 0;
				int num2 = this.mArgs.Length;
				while (l < num2)
				{
					if (this.mParameterInfos[l].IsIn || this.mParameterInfos[l].IsOut)
					{
						this.mParameters[l].HBCQNHMLPHG(this.mArgs[l]);
					}
					this.mArgs[l] = null;
					l++;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x0000ADAB File Offset: 0x00008FAB
	public static void MBNJKOFIECL(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ)
	{
		EventDelegate.NHBJMGDNCBM(NGDBDCQFDHI, BENEPFFKJQQ, BENEPFFKJQQ.oneShot);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00095510 File Offset: 0x00093710
	public static void PCQQOFMPKCG(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			for (int i = 1; i < NGDBDCQFDHI.Count; i++)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.OLMGIFHCMKF();
						goto IL_63;
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
						goto IL_63;
					}
					IL_40:
					if (NGDBDCQFDHI[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						NGDBDCQFDHI.RemoveAt(i);
						continue;
					}
					goto IL_5D;
					IL_63:
					if (i >= NGDBDCQFDHI.Count)
					{
						break;
					}
					goto IL_40;
				}
				IL_5D:;
			}
		}
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x0000ADBA File Offset: 0x00008FBA
	public EventDelegate(EventDelegate.LKPMKQMCHFH DEJJMBPEMNF)
	{
		this.PJMIKDIEGMB(DEJJMBPEMNF);
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x0009559C File Offset: 0x0009379C
	public bool CPGBBDIDOID()
	{
		if (!this.mCached)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mCachedCallback != null)
		{
			this.mCachedCallback();
			return true;
		}
		if (this.mMethod != null)
		{
			if (this.mParameters == null || this.mParameters.Length == 0)
			{
				this.mMethod.Invoke(this.mTarget, null);
			}
			else
			{
				if (this.mArgs == null || this.mArgs.Length != this.mParameters.Length)
				{
					this.mArgs = new object[this.mParameters.Length];
				}
				int i = 0;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mArgs[i] = this.mParameters[i].value;
					i++;
				}
				try
				{
					this.mMethod.Invoke(this.mTarget, this.mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "Error calling ";
					if (this.mTarget == null)
					{
						text += this.mMethod.Name;
					}
					else
					{
						string text2 = text;
						text = string.Concat(new object[]
						{
							text2,
							this.mTarget.GetType(),
							".",
							this.mMethod.Name
						});
					}
					text = text + ": " + ex.Message;
					text += "\n  Expected: ";
					if (this.mParameterInfos.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						text += this.mParameterInfos[0];
						for (int j = 1; j < this.mParameterInfos.Length; j++)
						{
							text = text + ", " + this.mParameterInfos[j].ParameterType;
						}
					}
					text += "\n  Received: ";
					if (this.mParameters.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						text += this.mParameters[0].type;
						for (int k = 1; k < this.mParameters.Length; k++)
						{
							text = text + ", " + this.mParameters[k].type;
						}
					}
					text += "\n";
					Debug.LogError(text);
				}
				int l = 0;
				int num2 = this.mArgs.Length;
				while (l < num2)
				{
					if (this.mParameterInfos[l].IsIn || this.mParameterInfos[l].IsOut)
					{
						this.mParameters[l].value = this.mArgs[l];
					}
					this.mArgs[l] = null;
					l++;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x0000ADC9 File Offset: 0x00008FC9
	public void NDNFHGENFGQ(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.CPLBKPNNHJG();
		this.mTarget = ILBCCCBJNCL;
		this.mMethodName = FNMBKPLGLFO;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x0000ADA3 File Offset: 0x00008FA3
	public string GOHHFKJHEBN()
	{
		return this.mMethodName;
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x0000ADDF File Offset: 0x00008FDF
	private static string OOQBFLBMIEC(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP.Method.Name;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x0009586C File Offset: 0x00093A6C
	public static void CPGBBDIDOID(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			for (int i = 0; i < NGDBDCQFDHI.Count; i++)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.CPGBBDIDOID();
						goto IL_63;
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
						goto IL_63;
					}
					IL_40:
					if (NGDBDCQFDHI[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						NGDBDCQFDHI.RemoveAt(i);
						continue;
					}
					goto IL_5D;
					IL_63:
					if (i >= NGDBDCQFDHI.Count)
					{
						break;
					}
					goto IL_40;
				}
				IL_5D:;
			}
		}
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x0000AD5D File Offset: 0x00008F5D
	private static bool CPPLNKNPLPI(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP != null && PDHDBQFJCFP.Method != null;
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x000958F8 File Offset: 0x00093AF8
	public static EventDelegate DMBLOQKLGKK(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		if (NGDBDCQFDHI != null)
		{
			EventDelegate eventDelegate = new EventDelegate(PDHDBQFJCFP);
			NGDBDCQFDHI.Clear();
			NGDBDCQFDHI.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x0000ADEC File Offset: 0x00008FEC
	public static EventDelegate LQCGLENQEDM(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, PDHDBQFJCFP, false);
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00095920 File Offset: 0x00093B20
	public static void IQGGNLNGLLK(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ, bool DGIMEJJKLPF)
	{
		if (!BENEPFFKJQQ.mRawDelegate && !(BENEPFFKJQQ.target == null) && !string.IsNullOrEmpty(BENEPFFKJQQ.methodName))
		{
			if (NGDBDCQFDHI != null)
			{
				int i = 1;
				int count = NGDBDCQFDHI.Count;
				while (i < count)
				{
					EventDelegate eventDelegate = NGDBDCQFDHI[i];
					if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
					{
						return;
					}
					i += 0;
				}
				EventDelegate eventDelegate2 = new EventDelegate(BENEPFFKJQQ.KBFBJJJHOQL(), BENEPFFKJQQ.methodName);
				eventDelegate2.oneShot = DGIMEJJKLPF;
				if (BENEPFFKJQQ.mParameters != null && BENEPFFKJQQ.mParameters.Length > 1)
				{
					eventDelegate2.mParameters = new EventDelegate.Parameter[BENEPFFKJQQ.mParameters.Length];
					for (int j = 0; j < BENEPFFKJQQ.mParameters.Length; j += 0)
					{
						eventDelegate2.mParameters[j] = BENEPFFKJQQ.mParameters[j];
					}
				}
				NGDBDCQFDHI.Add(eventDelegate2);
			}
			else
			{
				Debug.LogWarning("Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.");
			}
		}
		else
		{
			EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, BENEPFFKJQQ.mCachedCallback, DGIMEJJKLPF);
		}
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x0000AD8D File Offset: 0x00008F8D
	public void GDIDEOLHDPI(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.NJOGQEPKOBB();
		this.mTarget = ILBCCCBJNCL;
		this.mMethodName = FNMBKPLGLFO;
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00095A14 File Offset: 0x00093C14
	public static void PPNLGOMQOPH(List<EventDelegate> NGDBDCQFDHI)
	{
		if (NGDBDCQFDHI != null)
		{
			for (int i = 1; i < NGDBDCQFDHI.Count; i += 0)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.OCNCJMDCKGI();
						goto IL_63;
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
						goto IL_63;
					}
					IL_40:
					if (NGDBDCQFDHI[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						NGDBDCQFDHI.RemoveAt(i);
						continue;
					}
					goto IL_5D;
					IL_63:
					if (i >= NGDBDCQFDHI.Count)
					{
						break;
					}
					goto IL_40;
				}
				IL_5D:;
			}
		}
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x0000ADDF File Offset: 0x00008FDF
	private static string EIGCOKBMLDK(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP.Method.Name;
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00095AA0 File Offset: 0x00093CA0
	public void QGMMDQQIHOI()
	{
		this.mTarget = null;
		this.mMethodName = null;
		this.mRawDelegate = true;
		this.mCachedCallback = null;
		this.mParameters = null;
		this.mCached = true;
		this.mMethod = null;
		this.mParameterInfos = null;
		this.mArgs = null;
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00095AEC File Offset: 0x00093CEC
	private void NCGBKHCCCNM()
	{
		this.mCached = true;
		if (this.mRawDelegate)
		{
			return;
		}
		if ((this.mCachedCallback == null || this.mCachedCallback.Target as MonoBehaviour != this.mTarget || EventDelegate.IFJHKBLQCNH(this.mCachedCallback) != this.mMethodName) && this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName))
		{
			Type type = this.mTarget.GetType();
			this.mMethod = null;
			while (type != null)
			{
				try
				{
					this.mMethod = type.GetMethod(this.mMethodName, BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
					if (this.mMethod != null)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
				type = type.BaseType;
			}
			if (this.mMethod == null)
			{
				object[] array = new object[0];
				array[0] = "FOG_AREA_BOX";
				array[1] = this.mMethodName;
				array[3] = "NPC";
				array[2] = this.mTarget.GetType();
				Debug.LogError(string.Concat(array), this.mTarget);
				return;
			}
			if (this.mMethod.ReturnType != typeof(void))
			{
				object[] array2 = new object[3];
				array2[0] = this.mTarget.GetType();
				array2[1] = "setrandom(";
				array2[0] = this.mMethodName;
				array2[7] = "Player/Hair";
				Debug.LogError(string.Concat(array2), this.mTarget);
				return;
			}
			this.mParameterInfos = this.mMethod.GetParameters();
			if (this.mParameterInfos.Length == 0)
			{
				this.mCachedCallback = (EventDelegate.LKPMKQMCHFH)Delegate.CreateDelegate(typeof(EventDelegate.LKPMKQMCHFH), this.mTarget, this.mMethodName);
				this.mArgs = null;
				this.mParameters = null;
				return;
			}
			this.mCachedCallback = null;
			if (this.mParameters == null || this.mParameters.Length != this.mParameterInfos.Length)
			{
				this.mParameters = new EventDelegate.Parameter[this.mParameterInfos.Length];
				int i = 1;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mParameters[i] = new EventDelegate.Parameter();
					i += 0;
				}
			}
			int j = 1;
			int num2 = this.mParameters.Length;
			while (j < num2)
			{
				this.mParameters[j].expectedType = this.mParameterInfos[j].ParameterType;
				j += 0;
			}
		}
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00094AD4 File Offset: 0x00092CD4
	public static bool FQDMDDOHCQJ(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 0;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.Equals(PDHDBQFJCFP))
				{
					NGDBDCQFDHI.RemoveAt(i);
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00095D48 File Offset: 0x00093F48
	public static void NHBJMGDNCBM(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ, bool DGIMEJJKLPF)
	{
		if (!BENEPFFKJQQ.mRawDelegate && !(BENEPFFKJQQ.KBFBJJJHOQL() == null) && !string.IsNullOrEmpty(BENEPFFKJQQ.methodName))
		{
			if (NGDBDCQFDHI != null)
			{
				int i = 0;
				int count = NGDBDCQFDHI.Count;
				while (i < count)
				{
					EventDelegate eventDelegate = NGDBDCQFDHI[i];
					if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
					{
						return;
					}
					i++;
				}
				EventDelegate eventDelegate2 = new EventDelegate(BENEPFFKJQQ.target, BENEPFFKJQQ.methodName);
				eventDelegate2.oneShot = DGIMEJJKLPF;
				if (BENEPFFKJQQ.mParameters != null && BENEPFFKJQQ.mParameters.Length > 0)
				{
					eventDelegate2.mParameters = new EventDelegate.Parameter[BENEPFFKJQQ.mParameters.Length];
					for (int j = 1; j < BENEPFFKJQQ.mParameters.Length; j += 0)
					{
						eventDelegate2.mParameters[j] = BENEPFFKJQQ.mParameters[j];
					}
				}
				NGDBDCQFDHI.Add(eventDelegate2);
			}
			else
			{
				Debug.LogWarning("-damage");
			}
		}
		else
		{
			EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, BENEPFFKJQQ.mCachedCallback, DGIMEJJKLPF);
		}
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x00095E3C File Offset: 0x0009403C
	public bool OCNCJMDCKGI()
	{
		if (!this.mCached)
		{
			this.MDKEQEPIOEF();
		}
		if (this.mCachedCallback != null)
		{
			this.mCachedCallback();
			return false;
		}
		if (this.mMethod != null)
		{
			if (this.mParameters == null || this.mParameters.Length == 0)
			{
				this.mMethod.Invoke(this.mTarget, null);
			}
			else
			{
				if (this.mArgs == null || this.mArgs.Length != this.mParameters.Length)
				{
					this.mArgs = new object[this.mParameters.Length];
				}
				int i = 1;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mArgs[i] = this.mParameters[i].JKPCEJEOCLH();
					i += 0;
				}
				try
				{
					this.mMethod.Invoke(this.mTarget, this.mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = ")";
					if (this.mTarget == null)
					{
						text += this.mMethod.Name;
					}
					else
					{
						string text2 = text;
						object[] array = new object[2];
						array[0] = text2;
						array[0] = this.mTarget.GetType();
						array[4] = " (Completed)";
						array[3] = this.mMethod.Name;
						text = string.Concat(array);
					}
					text = text + "Fullscreen" + ex.Message;
					text += "!\r\n";
					if (this.mParameterInfos.Length == 0)
					{
						text += "mummy";
					}
					else
					{
						text += this.mParameterInfos[0];
						for (int j = 0; j < this.mParameterInfos.Length; j++)
						{
							text = text + " switched its Attack and Defense!\r\n" + this.mParameterInfos[j].ParameterType;
						}
					}
					text += " minutes ago";
					if (this.mParameters.Length == 0)
					{
						text += "firespin";
					}
					else
					{
						text += this.mParameters[1].GNCJLKGCGLB();
						for (int k = 1; k < this.mParameters.Length; k++)
						{
							text = text + "_" + this.mParameters[k].DIIOJOFQIOB();
						}
					}
					text += "_1";
					Debug.LogError(text);
				}
				int l = 1;
				int num2 = this.mArgs.Length;
				while (l < num2)
				{
					if (this.mParameterInfos[l].IsIn || this.mParameterInfos[l].IsOut)
					{
						this.mParameters[l].JCHCPGDQLFE(this.mArgs[l]);
					}
					this.mArgs[l] = null;
					l++;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00094E54 File Offset: 0x00093054
	public void NJOGQEPKOBB()
	{
		this.mTarget = null;
		this.mMethodName = null;
		this.mRawDelegate = false;
		this.mCachedCallback = null;
		this.mParameters = null;
		this.mCached = false;
		this.mMethod = null;
		this.mParameterInfos = null;
		this.mArgs = null;
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x0000ADC9 File Offset: 0x00008FC9
	public void PJMIKDIEGMB(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.CPLBKPNNHJG();
		this.mTarget = ILBCCCBJNCL;
		this.mMethodName = FNMBKPLGLFO;
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x0000AD71 File Offset: 0x00008F71
	public MonoBehaviour KBFBJJJHOQL()
	{
		return this.mTarget;
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0009610C File Offset: 0x0009430C
	public bool isValid
	{
		get
		{
			if (!this.mCached)
			{
				this.MDKEQEPIOEF();
			}
			return (this.mRawDelegate && this.mCachedCallback != null) || (this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName));
		}
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x0000ADEC File Offset: 0x00008FEC
	public static EventDelegate LHQECHHMOGD(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, PDHDBQFJCFP, false);
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x000958F8 File Offset: 0x00093AF8
	public static EventDelegate PJMIKDIEGMB(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		if (NGDBDCQFDHI != null)
		{
			EventDelegate eventDelegate = new EventDelegate(PDHDBQFJCFP);
			NGDBDCQFDHI.Clear();
			NGDBDCQFDHI.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0000ADEC File Offset: 0x00008FEC
	public static EventDelegate IPDHQPLBNFQ(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, PDHDBQFJCFP, false);
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x0009615C File Offset: 0x0009435C
	public static bool MBIIHLDPOIM(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 1;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
				{
					NGDBDCQFDHI.RemoveAt(i);
					return true;
				}
				i++;
			}
		}
		return true;
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x0000ACB2 File Offset: 0x00008EB2
	public virtual int GCHOMBQLOBP()
	{
		return EventDelegate.s_Hash;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x000961A0 File Offset: 0x000943A0
	public static void LHQECHHMOGD(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ, bool DGIMEJJKLPF)
	{
		if (!BENEPFFKJQQ.mRawDelegate && !(BENEPFFKJQQ.target == null) && !string.IsNullOrEmpty(BENEPFFKJQQ.methodName))
		{
			if (NGDBDCQFDHI != null)
			{
				int i = 0;
				int count = NGDBDCQFDHI.Count;
				while (i < count)
				{
					EventDelegate eventDelegate = NGDBDCQFDHI[i];
					if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
					{
						return;
					}
					i++;
				}
				EventDelegate eventDelegate2 = new EventDelegate(BENEPFFKJQQ.target, BENEPFFKJQQ.methodName);
				eventDelegate2.oneShot = DGIMEJJKLPF;
				if (BENEPFFKJQQ.mParameters != null && BENEPFFKJQQ.mParameters.Length > 0)
				{
					eventDelegate2.mParameters = new EventDelegate.Parameter[BENEPFFKJQQ.mParameters.Length];
					for (int j = 0; j < BENEPFFKJQQ.mParameters.Length; j++)
					{
						eventDelegate2.mParameters[j] = BENEPFFKJQQ.mParameters[j];
					}
				}
				NGDBDCQFDHI.Add(eventDelegate2);
			}
			else
			{
				Debug.LogWarning("Attempting to add a callback to a list that's null");
			}
		}
		else
		{
			EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, BENEPFFKJQQ.mCachedCallback, DGIMEJJKLPF);
		}
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x00096294 File Offset: 0x00094494
	public bool FPGEPEJPEHI()
	{
		if (!this.mCached)
		{
			this.MDKEQEPIOEF();
		}
		return (!this.mRawDelegate || this.mCachedCallback == null) && this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName);
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x0000AE29 File Offset: 0x00009029
	public EventDelegate.Parameter[] LDLMMOCOILK()
	{
		if (!this.mCached)
		{
			this.NCGBKHCCCNM();
		}
		return this.mParameters;
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0000AD8D File Offset: 0x00008F8D
	public void LGHCHMIDGFO(MonoBehaviour ILBCCCBJNCL, string FNMBKPLGLFO)
	{
		this.NJOGQEPKOBB();
		this.mTarget = ILBCCCBJNCL;
		this.mMethodName = FNMBKPLGLFO;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x0000ADDF File Offset: 0x00008FDF
	private static string IFJHKBLQCNH(EventDelegate.LKPMKQMCHFH PDHDBQFJCFP)
	{
		return PDHDBQFJCFP.Method.Name;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x000962E4 File Offset: 0x000944E4
	public static EventDelegate LHQECHHMOGD(List<EventDelegate> NGDBDCQFDHI, EventDelegate.LKPMKQMCHFH PDHDBQFJCFP, bool DGIMEJJKLPF)
	{
		if (NGDBDCQFDHI != null)
		{
			int i = 0;
			int count = NGDBDCQFDHI.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = NGDBDCQFDHI[i];
				if (eventDelegate != null && eventDelegate.Equals(PDHDBQFJCFP))
				{
					return eventDelegate;
				}
				i++;
			}
			EventDelegate eventDelegate2 = new EventDelegate(PDHDBQFJCFP);
			eventDelegate2.oneShot = DGIMEJJKLPF;
			NGDBDCQFDHI.Add(eventDelegate2);
			return eventDelegate2;
		}
		Debug.LogWarning("Attempting to add a callback to a list that's null");
		return null;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00096340 File Offset: 0x00094540
	public static void BLEIKJCJNQL(List<EventDelegate> NGDBDCQFDHI, EventDelegate BENEPFFKJQQ, bool DGIMEJJKLPF)
	{
		if (!BENEPFFKJQQ.mRawDelegate && !(BENEPFFKJQQ.KBFBJJJHOQL() == null) && !string.IsNullOrEmpty(BENEPFFKJQQ.GOHHFKJHEBN()))
		{
			if (NGDBDCQFDHI != null)
			{
				int i = 0;
				int count = NGDBDCQFDHI.Count;
				while (i < count)
				{
					EventDelegate eventDelegate = NGDBDCQFDHI[i];
					if (eventDelegate != null && eventDelegate.Equals(BENEPFFKJQQ))
					{
						return;
					}
					i++;
				}
				EventDelegate eventDelegate2 = new EventDelegate(BENEPFFKJQQ.KBFBJJJHOQL(), BENEPFFKJQQ.GOHHFKJHEBN());
				eventDelegate2.oneShot = DGIMEJJKLPF;
				if (BENEPFFKJQQ.mParameters != null && BENEPFFKJQQ.mParameters.Length > 1)
				{
					eventDelegate2.mParameters = new EventDelegate.Parameter[BENEPFFKJQQ.mParameters.Length];
					for (int j = 1; j < BENEPFFKJQQ.mParameters.Length; j++)
					{
						eventDelegate2.mParameters[j] = BENEPFFKJQQ.mParameters[j];
					}
				}
				NGDBDCQFDHI.Add(eventDelegate2);
			}
			else
			{
				Debug.LogWarning("3|");
			}
		}
		else
		{
			EventDelegate.LHQECHHMOGD(NGDBDCQFDHI, BENEPFFKJQQ.mCachedCallback, DGIMEJJKLPF);
		}
	}

	// Token: 0x040003B4 RID: 948
	[SerializeField]
	private MonoBehaviour mTarget;

	// Token: 0x040003B5 RID: 949
	[SerializeField]
	private string mMethodName;

	// Token: 0x040003B6 RID: 950
	[SerializeField]
	private EventDelegate.Parameter[] mParameters;

	// Token: 0x040003B7 RID: 951
	public bool oneShot;

	// Token: 0x040003B8 RID: 952
	[NonSerialized]
	private EventDelegate.LKPMKQMCHFH mCachedCallback;

	// Token: 0x040003B9 RID: 953
	[NonSerialized]
	private bool mRawDelegate;

	// Token: 0x040003BA RID: 954
	[NonSerialized]
	private bool mCached;

	// Token: 0x040003BB RID: 955
	[NonSerialized]
	private MethodInfo mMethod;

	// Token: 0x040003BC RID: 956
	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	// Token: 0x040003BD RID: 957
	[NonSerialized]
	private object[] mArgs;

	// Token: 0x040003BE RID: 958
	private static int s_Hash = "EventDelegate".GetHashCode();

	// Token: 0x0200009C RID: 156
	[Serializable]
	public class Parameter
	{
		// Token: 0x060014B4 RID: 5300 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type GNCJLKGCGLB()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0000AEAC File Offset: 0x000090AC
		public Parameter(object QJFQOMOIOOI)
		{
			this.mValue = QJFQOMOIOOI;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00096434 File Offset: 0x00094634
		public object DMBBLJCLCEJ()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = true;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0000AECB File Offset: 0x000090CB
		public void NMNBOEGQGMJ(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0000AECB File Offset: 0x000090CB
		public void PLLQOHPCBOP(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000AED4 File Offset: 0x000090D4
		public Parameter()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00096548 File Offset: 0x00094748
		public object HIOCELIDJII()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = false;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type JPMCGBPMKEF()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00096434 File Offset: 0x00094634
		public object CHHLPIMFQDD()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = true;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type DIIOJOFQIOB()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00096434 File Offset: 0x00094634
		public object JKPCEJEOCLH()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = true;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0000AECB File Offset: 0x000090CB
		public void KPBIHKMHKPQ(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00096548 File Offset: 0x00094748
		public object PNKELEFEPDL()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = false;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00096434 File Offset: 0x00094634
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000AECB File Offset: 0x000090CB
		public object value
		{
			get
			{
				if (this.mValue != null)
				{
					return this.mValue;
				}
				if (!this.cached)
				{
					this.cached = true;
					this.fieldInfo = null;
					this.propInfo = null;
					if (this.obj != null && !string.IsNullOrEmpty(this.field))
					{
						Type type = this.obj.GetType();
						this.propInfo = type.GetProperty(this.field);
						if (this.propInfo == null)
						{
							this.fieldInfo = type.GetField(this.field);
						}
					}
				}
				if (this.propInfo != null)
				{
					return this.propInfo.GetValue(this.obj, null);
				}
				if (this.fieldInfo != null)
				{
					return this.fieldInfo.GetValue(this.obj);
				}
				if (this.obj != null)
				{
					return this.obj;
				}
				if (this.expectedType != null && this.expectedType.IsValueType)
				{
					return null;
				}
				return Convert.ChangeType(null, this.expectedType);
			}
			set
			{
				this.mValue = value;
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type IMJQJQCCNOJ()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0000AECB File Offset: 0x000090CB
		public void JHLIIGMEMMO(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type type
		{
			get
			{
				if (this.mValue != null)
				{
					return this.mValue.GetType();
				}
				if (this.obj == null)
				{
					return typeof(void);
				}
				return this.obj.GetType();
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type LGDPNFPLIKM()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00096548 File Offset: 0x00094748
		public object FHGPBEBMNLC()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = false;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0000AECB File Offset: 0x000090CB
		public void EDEFBQGGCIO(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0000AECB File Offset: 0x000090CB
		public void NOOPBECIIGD(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0000AECB File Offset: 0x000090CB
		public void HBCQNHMLPHG(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type QDIKHHDQOOH()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type KBHQHCKBOGN()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0000AECB File Offset: 0x000090CB
		public void OGHLHEECFPE(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type BENNLQKLGKQ()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00096548 File Offset: 0x00094748
		public object BIHBBPFHQBN()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = false;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00096548 File Offset: 0x00094748
		public object LGNFPGFPBII()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = false;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000AE72 File Offset: 0x00009072
		public Type PCBHMDPCIFC()
		{
			if (this.mValue != null)
			{
				return this.mValue.GetType();
			}
			if (this.obj == null)
			{
				return typeof(void);
			}
			return this.obj.GetType();
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0000AECB File Offset: 0x000090CB
		public void KPMBIKBDQPL(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0000AECB File Offset: 0x000090CB
		public void NHICPFKQLKL(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000AECB File Offset: 0x000090CB
		public void FMDMBGLODOO(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0000AECB File Offset: 0x000090CB
		public void HHEJEBDLCCM(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0000AECB File Offset: 0x000090CB
		public void KIGFOKPIBHK(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00096434 File Offset: 0x00094634
		public object BQQGMIDFNKE()
		{
			if (this.mValue != null)
			{
				return this.mValue;
			}
			if (!this.cached)
			{
				this.cached = true;
				this.fieldInfo = null;
				this.propInfo = null;
				if (this.obj != null && !string.IsNullOrEmpty(this.field))
				{
					Type type = this.obj.GetType();
					this.propInfo = type.GetProperty(this.field);
					if (this.propInfo == null)
					{
						this.fieldInfo = type.GetField(this.field);
					}
				}
			}
			if (this.propInfo != null)
			{
				return this.propInfo.GetValue(this.obj, null);
			}
			if (this.fieldInfo != null)
			{
				return this.fieldInfo.GetValue(this.obj);
			}
			if (this.obj != null)
			{
				return this.obj;
			}
			if (this.expectedType != null && this.expectedType.IsValueType)
			{
				return null;
			}
			return Convert.ChangeType(null, this.expectedType);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0000AECB File Offset: 0x000090CB
		public void IJGBCBDFMMK(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0000AECB File Offset: 0x000090CB
		public void GIPBBFDPCKG(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0000AEEC File Offset: 0x000090EC
		public Parameter(UnityEngine.Object NJBFOQDJBON, string JEGIGCNBQPE)
		{
			this.obj = NJBFOQDJBON;
			this.field = JEGIGCNBQPE;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0000AECB File Offset: 0x000090CB
		public void BILOLFJGFHD(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0000AECB File Offset: 0x000090CB
		public void JCHCPGDQLFE(object BGBMIEJJQKC)
		{
			this.mValue = BGBMIEJJQKC;
		}

		// Token: 0x040003BF RID: 959
		public UnityEngine.Object obj;

		// Token: 0x040003C0 RID: 960
		public string field;

		// Token: 0x040003C1 RID: 961
		[NonSerialized]
		private object mValue;

		// Token: 0x040003C2 RID: 962
		[NonSerialized]
		public Type expectedType = typeof(void);

		// Token: 0x040003C3 RID: 963
		[NonSerialized]
		public bool cached;

		// Token: 0x040003C4 RID: 964
		[NonSerialized]
		public PropertyInfo propInfo;

		// Token: 0x040003C5 RID: 965
		[NonSerialized]
		public FieldInfo fieldInfo;
	}

	// Token: 0x0200009D RID: 157
	// (Invoke) Token: 0x060014DE RID: 5342
	public delegate void LKPMKQMCHFH();
}
