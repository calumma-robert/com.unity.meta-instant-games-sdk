namespace Meta.InstantGames
{
    /// <summary>
    /// Represents a mapping from locales to translations of a given string. Each property is an  optional five-character Facebook locale code of the form xx_XX. See https://lookaside.facebook.com/developers/resources/?id=FacebookLocales.xml for a complete list of supported locale codes.
    /// </summary>
    public partial class LocalizationsDict : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of LocalizationsDict
        /// </summary>
        /// <param name="af_ZA">Afrikaans</param>
        /// <param name="ak_GH">Akan</param>
        /// <param name="am_ET">Amharic</param>
        /// <param name="ar_AR">Arabic</param>
        /// <param name="as_IN">Assamese</param>
        /// <param name="ay_BO">Aymara</param>
        /// <param name="az_AZ">Azerbaijani</param>
        /// <param name="be_BY">Belarusian</param>
        /// <param name="bg_BG">Bulgarian</param>
        /// <param name="bn_IN">Bengali</param>
        /// <param name="bp_IN">Bhojpuri</param>
        /// <param name="br_FR">Breton</param>
        /// <param name="bs_BA">Bosnian</param>
        /// <param name="ca_ES">Catalan</param>
        /// <param name="cb_IQ">Sorani Kurdish</param>
        /// <param name="ck_US">Cherokee</param>
        /// <param name="co_FR">Corsican</param>
        /// <param name="cs_CZ">Czech</param>
        /// <param name="cx_PH">Cebuano</param>
        /// <param name="cy_GB">Welsh</param>
        /// <param name="da_DK">Danish</param>
        /// <param name="de_DE">German</param>
        /// <param name="el_GR">Greek</param>
        /// <param name="en_GB">English (UK)</param>
        /// <param name="en_PI">English (Pirate)</param>
        /// <param name="en_UD">English (Upside Down)</param>
        /// <param name="en_US">English (US)</param>
        /// <param name="eo_EO">Esperanto</param>
        /// <param name="es_ES">Spanish (Spain)</param>
        /// <param name="es_LA">Spanish</param>
        /// <param name="es_MX">Spanish (Mexico)</param>
        /// <param name="et_EE">Estonian</param>
        /// <param name="eu_ES">Basque</param>
        /// <param name="fa_IR">Persian</param>
        /// <param name="fb_LT">Leet Speak</param>
        /// <param name="ff_NG">Fula</param>
        /// <param name="fi_FI">Finnish</param>
        /// <param name="fo_FO">Faroese</param>
        /// <param name="fr_CA">French (Canada)</param>
        /// <param name="fr_FR">French (France)</param>
        /// <param name="fy_NL">Frisian</param>
        /// <param name="ga_IE">Irish</param>
        /// <param name="gl_ES">Galician</param>
        /// <param name="gn_PY">Guarani</param>
        /// <param name="gu_IN">Gujarati</param>
        /// <param name="gx_GR">Classical Greek</param>
        /// <param name="ha_NG">Hausa</param>
        /// <param name="he_IL">Hebrew</param>
        /// <param name="hi_IN">Hindi</param>
        /// <param name="hr_HR">Croatian</param>
        /// <param name="ht_HT">Haitian Creole</param>
        /// <param name="hu_HU">Hungarian</param>
        /// <param name="hy_AM">Armenian</param>
        /// <param name="id_ID">Indonesian</param>
        /// <param name="ig_NG">Igbo</param>
        /// <param name="is_IS">Icelandic</param>
        /// <param name="it_IT">Italian</param>
        /// <param name="jp_JP">Japanese</param>
        /// <param name="jp_KS">Japanese (Kansai)</param>
        /// <param name="jv_ID">Javanese</param>
        /// <param name="ka_GE">Georgian</param>
        /// <param name="kk_KZ">Kazakh</param>
        /// <param name="km_KH">Khmer</param>
        /// <param name="kn_IN">Kannada</param>
        /// <param name="ko_KR">Korean</param>
        /// <param name="ks_IN">Kashmiri</param>
        /// <param name="ku_TR">Kurdish (Kurmanji)</param>
        /// <param name="ky_KG">Kyrgyz</param>
        /// <param name="la_VA">Latin</param>
        /// <param name="lg_UG">Ganda</param>
        /// <param name="li_NL">Limburgish</param>
        /// <param name="ln_CD">Lingala</param>
        /// <param name="lo_LA">Lao</param>
        /// <param name="lt_LT">Lithuanian</param>
        /// <param name="lv_LV">Latvian</param>
        /// <param name="mg_MG">Malagasy</param>
        /// <param name="mi_NZ">Māori</param>
        /// <param name="mk_MK">Macedonian</param>
        /// <param name="ml_IN">Malayalam</param>
        /// <param name="mn_MN">Mongolian</param>
        /// <param name="mr_IN">Marathi</param>
        /// <param name="ms_MY">Malay</param>
        /// <param name="mt_MT">Maltese</param>
        /// <param name="my_MM">Burmese</param>
        /// <param name="nb_NO">Norwegian (bokmal)</param>
        /// <param name="nd_ZW">Northern Ndebele</param>
        /// <param name="ne_NP">Nepali</param>
        /// <param name="nl_BE">Dutch (België)</param>
        /// <param name="nl_NL">Dutch</param>
        /// <param name="nn_NO">Norwegian (nynorsk)</param>
        /// <param name="nr_ZA">Southern Ndebele</param>
        /// <param name="ns_ZA">Northern Sotho</param>
        /// <param name="ny_MW">Chewa</param>
        /// <param name="or_IN">Oriya</param>
        /// <param name="pa_IN">Punjabi</param>
        /// <param name="pl_PL">Polish</param>
        /// <param name="ps_AF">Pashto</param>
        /// <param name="pt_BR">Portuguese (Brazil)</param>
        /// <param name="pt_PT">Portuguese (Portugal)</param>
        /// <param name="qc_GT">Quiché</param>
        /// <param name="qu_PE">Quechua</param>
        /// <param name="qz_MM">Burmese (Zawgyi)</param>
        /// <param name="rm_CH">Romansh</param>
        /// <param name="ro_RO">Romanian</param>
        /// <param name="ru_RU">Russian</param>
        /// <param name="rw_RW">Kinyarwanda</param>
        /// <param name="sa_IN">Sanskrit</param>
        /// <param name="sc_IT">Sardinian</param>
        /// <param name="se_NO">Northern Sámi</param>
        /// <param name="si_LK">Sinhala</param>
        /// <param name="sk_SK">Slovak</param>
        /// <param name="sl_SI">Slovenian</param>
        /// <param name="sn_ZW">Shona</param>
        /// <param name="so_SO">Somali</param>
        /// <param name="sq_AL">Albanian</param>
        /// <param name="sr_RS">Serbian</param>
        /// <param name="ss_SZ">Swazi</param>
        /// <param name="st_ZA">Southern Sotho</param>
        /// <param name="sv_SE">Swedish</param>
        /// <param name="sw_KE">Swahili</param>
        /// <param name="sy_SY">Syriac</param>
        /// <param name="sz_PL">Silesian</param>
        /// <param name="ta_IN">Tamil</param>
        /// <param name="te_IN">Telugu</param>
        /// <param name="tg_TJ">Tajik</param>
        /// <param name="th_TH">Thai</param>
        /// <param name="tk_TM">Turkmen</param>
        /// <param name="tl_PH">Filipino</param>
        /// <param name="tl_ST">Klingon</param>
        /// <param name="tn_BW">Tswana</param>
        /// <param name="tr_TR">Turkish</param>
        /// <param name="ts_ZA">Tsonga</param>
        /// <param name="tt_RU">Tatar</param>
        /// <param name="tz_MA">Tamazight</param>
        /// <param name="uk_UA">Ukrainian</param>
        /// <param name="ur_PK">Urdu</param>
        /// <param name="uz_UZ">Uzbek</param>
        /// <param name="ve_ZA">Venda</param>
        /// <param name="vi_VN">Vietnamese</param>
        /// <param name="wo_SN">Wolof</param>
        /// <param name="xh_ZA">Xhosa</param>
        /// <param name="yi_DE">Yiddish</param>
        /// <param name="yo_NG">Yoruba</param>
        /// <param name="zh_CN">Simplified Chinese (China)</param>
        /// <param name="zh_HK">Traditional Chinese (Hong Kong)</param>
        /// <param name="zh_TW">Traditional Chinese (Taiwan)</param>
        /// <param name="zu_ZA">Zulu</param>
        /// <param name="zz_TR">Zazaki</param>
        public LocalizationsDict(string af_ZA = null, string ak_GH = null, string am_ET = null, string ar_AR = null, string as_IN = null, string ay_BO = null, string az_AZ = null, string be_BY = null, string bg_BG = null, string bn_IN = null, string bp_IN = null, string br_FR = null, string bs_BA = null, string ca_ES = null, string cb_IQ = null, string ck_US = null, string co_FR = null, string cs_CZ = null, string cx_PH = null, string cy_GB = null, string da_DK = null, string de_DE = null, string el_GR = null, string en_GB = null, string en_PI = null, string en_UD = null, string en_US = null, string eo_EO = null, string es_ES = null, string es_LA = null, string es_MX = null, string et_EE = null, string eu_ES = null, string fa_IR = null, string fb_LT = null, string ff_NG = null, string fi_FI = null, string fo_FO = null, string fr_CA = null, string fr_FR = null, string fy_NL = null, string ga_IE = null, string gl_ES = null, string gn_PY = null, string gu_IN = null, string gx_GR = null, string ha_NG = null, string he_IL = null, string hi_IN = null, string hr_HR = null, string ht_HT = null, string hu_HU = null, string hy_AM = null, string id_ID = null, string ig_NG = null, string is_IS = null, string it_IT = null, string jp_JP = null, string jp_KS = null, string jv_ID = null, string ka_GE = null, string kk_KZ = null, string km_KH = null, string kn_IN = null, string ko_KR = null, string ks_IN = null, string ku_TR = null, string ky_KG = null, string la_VA = null, string lg_UG = null, string li_NL = null, string ln_CD = null, string lo_LA = null, string lt_LT = null, string lv_LV = null, string mg_MG = null, string mi_NZ = null, string mk_MK = null, string ml_IN = null, string mn_MN = null, string mr_IN = null, string ms_MY = null, string mt_MT = null, string my_MM = null, string nb_NO = null, string nd_ZW = null, string ne_NP = null, string nl_BE = null, string nl_NL = null, string nn_NO = null, string nr_ZA = null, string ns_ZA = null, string ny_MW = null, string or_IN = null, string pa_IN = null, string pl_PL = null, string ps_AF = null, string pt_BR = null, string pt_PT = null, string qc_GT = null, string qu_PE = null, string qz_MM = null, string rm_CH = null, string ro_RO = null, string ru_RU = null, string rw_RW = null, string sa_IN = null, string sc_IT = null, string se_NO = null, string si_LK = null, string sk_SK = null, string sl_SI = null, string sn_ZW = null, string so_SO = null, string sq_AL = null, string sr_RS = null, string ss_SZ = null, string st_ZA = null, string sv_SE = null, string sw_KE = null, string sy_SY = null, string sz_PL = null, string ta_IN = null, string te_IN = null, string tg_TJ = null, string th_TH = null, string tk_TM = null, string tl_PH = null, string tl_ST = null, string tn_BW = null, string tr_TR = null, string ts_ZA = null, string tt_RU = null, string tz_MA = null, string uk_UA = null, string ur_PK = null, string uz_UZ = null, string ve_ZA = null, string vi_VN = null, string wo_SN = null, string xh_ZA = null, string yi_DE = null, string yo_NG = null, string zh_CN = null, string zh_HK = null, string zh_TW = null, string zu_ZA = null, string zz_TR = null)
        {
            Af_ZA = af_ZA;
            Ak_GH = ak_GH;
            Am_ET = am_ET;
            Ar_AR = ar_AR;
            As_IN = as_IN;
            Ay_BO = ay_BO;
            Az_AZ = az_AZ;
            Be_BY = be_BY;
            Bg_BG = bg_BG;
            Bn_IN = bn_IN;
            Bp_IN = bp_IN;
            Br_FR = br_FR;
            Bs_BA = bs_BA;
            Ca_ES = ca_ES;
            Cb_IQ = cb_IQ;
            Ck_US = ck_US;
            Co_FR = co_FR;
            Cs_CZ = cs_CZ;
            Cx_PH = cx_PH;
            Cy_GB = cy_GB;
            Da_DK = da_DK;
            De_DE = de_DE;
            El_GR = el_GR;
            En_GB = en_GB;
            En_PI = en_PI;
            En_UD = en_UD;
            En_US = en_US;
            Eo_EO = eo_EO;
            Es_ES = es_ES;
            Es_LA = es_LA;
            Es_MX = es_MX;
            Et_EE = et_EE;
            Eu_ES = eu_ES;
            Fa_IR = fa_IR;
            Fb_LT = fb_LT;
            Ff_NG = ff_NG;
            Fi_FI = fi_FI;
            Fo_FO = fo_FO;
            Fr_CA = fr_CA;
            Fr_FR = fr_FR;
            Fy_NL = fy_NL;
            Ga_IE = ga_IE;
            Gl_ES = gl_ES;
            Gn_PY = gn_PY;
            Gu_IN = gu_IN;
            Gx_GR = gx_GR;
            Ha_NG = ha_NG;
            He_IL = he_IL;
            Hi_IN = hi_IN;
            Hr_HR = hr_HR;
            Ht_HT = ht_HT;
            Hu_HU = hu_HU;
            Hy_AM = hy_AM;
            Id_ID = id_ID;
            Ig_NG = ig_NG;
            Is_IS = is_IS;
            It_IT = it_IT;
            Jp_JP = jp_JP;
            Jp_KS = jp_KS;
            Jv_ID = jv_ID;
            Ka_GE = ka_GE;
            Kk_KZ = kk_KZ;
            Km_KH = km_KH;
            Kn_IN = kn_IN;
            Ko_KR = ko_KR;
            Ks_IN = ks_IN;
            Ku_TR = ku_TR;
            Ky_KG = ky_KG;
            La_VA = la_VA;
            Lg_UG = lg_UG;
            Li_NL = li_NL;
            Ln_CD = ln_CD;
            Lo_LA = lo_LA;
            Lt_LT = lt_LT;
            Lv_LV = lv_LV;
            Mg_MG = mg_MG;
            Mi_NZ = mi_NZ;
            Mk_MK = mk_MK;
            Ml_IN = ml_IN;
            Mn_MN = mn_MN;
            Mr_IN = mr_IN;
            Ms_MY = ms_MY;
            Mt_MT = mt_MT;
            My_MM = my_MM;
            Nb_NO = nb_NO;
            Nd_ZW = nd_ZW;
            Ne_NP = ne_NP;
            Nl_BE = nl_BE;
            Nl_NL = nl_NL;
            Nn_NO = nn_NO;
            Nr_ZA = nr_ZA;
            Ns_ZA = ns_ZA;
            Ny_MW = ny_MW;
            Or_IN = or_IN;
            Pa_IN = pa_IN;
            Pl_PL = pl_PL;
            Ps_AF = ps_AF;
            Pt_BR = pt_BR;
            Pt_PT = pt_PT;
            Qc_GT = qc_GT;
            Qu_PE = qu_PE;
            Qz_MM = qz_MM;
            Rm_CH = rm_CH;
            Ro_RO = ro_RO;
            Ru_RU = ru_RU;
            Rw_RW = rw_RW;
            Sa_IN = sa_IN;
            Sc_IT = sc_IT;
            Se_NO = se_NO;
            Si_LK = si_LK;
            Sk_SK = sk_SK;
            Sl_SI = sl_SI;
            Sn_ZW = sn_ZW;
            So_SO = so_SO;
            Sq_AL = sq_AL;
            Sr_RS = sr_RS;
            Ss_SZ = ss_SZ;
            St_ZA = st_ZA;
            Sv_SE = sv_SE;
            Sw_KE = sw_KE;
            Sy_SY = sy_SY;
            Sz_PL = sz_PL;
            Ta_IN = ta_IN;
            Te_IN = te_IN;
            Tg_TJ = tg_TJ;
            Th_TH = th_TH;
            Tk_TM = tk_TM;
            Tl_PH = tl_PH;
            Tl_ST = tl_ST;
            Tn_BW = tn_BW;
            Tr_TR = tr_TR;
            Ts_ZA = ts_ZA;
            Tt_RU = tt_RU;
            Tz_MA = tz_MA;
            Uk_UA = uk_UA;
            Ur_PK = ur_PK;
            Uz_UZ = uz_UZ;
            Ve_ZA = ve_ZA;
            Vi_VN = vi_VN;
            Wo_SN = wo_SN;
            Xh_ZA = xh_ZA;
            Yi_DE = yi_DE;
            Yo_NG = yo_NG;
            Zh_CN = zh_CN;
            Zh_HK = zh_HK;
            Zh_TW = zh_TW;
            Zu_ZA = zu_ZA;
            Zz_TR = zz_TR;
        }

        /// <summary>
        /// Afrikaans
        /// </summary>
        public string Af_ZA
        {
            get => GetMemberString("af_ZA");
            private set => SetMemberString("af_ZA", value);
        }

        /// <summary>
        /// Akan
        /// </summary>
        public string Ak_GH
        {
            get => GetMemberString("ak_GH");
            private set => SetMemberString("ak_GH", value);
        }

        /// <summary>
        /// Amharic
        /// </summary>
        public string Am_ET
        {
            get => GetMemberString("am_ET");
            private set => SetMemberString("am_ET", value);
        }

        /// <summary>
        /// Arabic
        /// </summary>
        public string Ar_AR
        {
            get => GetMemberString("ar_AR");
            private set => SetMemberString("ar_AR", value);
        }

        /// <summary>
        /// Assamese
        /// </summary>
        public string As_IN
        {
            get => GetMemberString("as_IN");
            private set => SetMemberString("as_IN", value);
        }

        /// <summary>
        /// Aymara
        /// </summary>
        public string Ay_BO
        {
            get => GetMemberString("ay_BO");
            private set => SetMemberString("ay_BO", value);
        }

        /// <summary>
        /// Azerbaijani
        /// </summary>
        public string Az_AZ
        {
            get => GetMemberString("az_AZ");
            private set => SetMemberString("az_AZ", value);
        }

        /// <summary>
        /// Belarusian
        /// </summary>
        public string Be_BY
        {
            get => GetMemberString("be_BY");
            private set => SetMemberString("be_BY", value);
        }

        /// <summary>
        /// Bulgarian
        /// </summary>
        public string Bg_BG
        {
            get => GetMemberString("bg_BG");
            private set => SetMemberString("bg_BG", value);
        }

        /// <summary>
        /// Bengali
        /// </summary>
        public string Bn_IN
        {
            get => GetMemberString("bn_IN");
            private set => SetMemberString("bn_IN", value);
        }

        /// <summary>
        /// Bhojpuri
        /// </summary>
        public string Bp_IN
        {
            get => GetMemberString("bp_IN");
            private set => SetMemberString("bp_IN", value);
        }

        /// <summary>
        /// Breton
        /// </summary>
        public string Br_FR
        {
            get => GetMemberString("br_FR");
            private set => SetMemberString("br_FR", value);
        }

        /// <summary>
        /// Bosnian
        /// </summary>
        public string Bs_BA
        {
            get => GetMemberString("bs_BA");
            private set => SetMemberString("bs_BA", value);
        }

        /// <summary>
        /// Catalan
        /// </summary>
        public string Ca_ES
        {
            get => GetMemberString("ca_ES");
            private set => SetMemberString("ca_ES", value);
        }

        /// <summary>
        /// Sorani Kurdish
        /// </summary>
        public string Cb_IQ
        {
            get => GetMemberString("cb_IQ");
            private set => SetMemberString("cb_IQ", value);
        }

        /// <summary>
        /// Cherokee
        /// </summary>
        public string Ck_US
        {
            get => GetMemberString("ck_US");
            private set => SetMemberString("ck_US", value);
        }

        /// <summary>
        /// Corsican
        /// </summary>
        public string Co_FR
        {
            get => GetMemberString("co_FR");
            private set => SetMemberString("co_FR", value);
        }

        /// <summary>
        /// Czech
        /// </summary>
        public string Cs_CZ
        {
            get => GetMemberString("cs_CZ");
            private set => SetMemberString("cs_CZ", value);
        }

        /// <summary>
        /// Cebuano
        /// </summary>
        public string Cx_PH
        {
            get => GetMemberString("cx_PH");
            private set => SetMemberString("cx_PH", value);
        }

        /// <summary>
        /// Welsh
        /// </summary>
        public string Cy_GB
        {
            get => GetMemberString("cy_GB");
            private set => SetMemberString("cy_GB", value);
        }

        /// <summary>
        /// Danish
        /// </summary>
        public string Da_DK
        {
            get => GetMemberString("da_DK");
            private set => SetMemberString("da_DK", value);
        }

        /// <summary>
        /// German
        /// </summary>
        public string De_DE
        {
            get => GetMemberString("de_DE");
            private set => SetMemberString("de_DE", value);
        }

        /// <summary>
        /// Greek
        /// </summary>
        public string El_GR
        {
            get => GetMemberString("el_GR");
            private set => SetMemberString("el_GR", value);
        }

        /// <summary>
        /// English (UK)
        /// </summary>
        public string En_GB
        {
            get => GetMemberString("en_GB");
            private set => SetMemberString("en_GB", value);
        }

        /// <summary>
        /// English (Pirate)
        /// </summary>
        public string En_PI
        {
            get => GetMemberString("en_PI");
            private set => SetMemberString("en_PI", value);
        }

        /// <summary>
        /// English (Upside Down)
        /// </summary>
        public string En_UD
        {
            get => GetMemberString("en_UD");
            private set => SetMemberString("en_UD", value);
        }

        /// <summary>
        /// English (US)
        /// </summary>
        public string En_US
        {
            get => GetMemberString("en_US");
            private set => SetMemberString("en_US", value);
        }

        /// <summary>
        /// Esperanto
        /// </summary>
        public string Eo_EO
        {
            get => GetMemberString("eo_EO");
            private set => SetMemberString("eo_EO", value);
        }

        /// <summary>
        /// Spanish (Spain)
        /// </summary>
        public string Es_ES
        {
            get => GetMemberString("es_ES");
            private set => SetMemberString("es_ES", value);
        }

        /// <summary>
        /// Spanish
        /// </summary>
        public string Es_LA
        {
            get => GetMemberString("es_LA");
            private set => SetMemberString("es_LA", value);
        }

        /// <summary>
        /// Spanish (Mexico)
        /// </summary>
        public string Es_MX
        {
            get => GetMemberString("es_MX");
            private set => SetMemberString("es_MX", value);
        }

        /// <summary>
        /// Estonian
        /// </summary>
        public string Et_EE
        {
            get => GetMemberString("et_EE");
            private set => SetMemberString("et_EE", value);
        }

        /// <summary>
        /// Basque
        /// </summary>
        public string Eu_ES
        {
            get => GetMemberString("eu_ES");
            private set => SetMemberString("eu_ES", value);
        }

        /// <summary>
        /// Persian
        /// </summary>
        public string Fa_IR
        {
            get => GetMemberString("fa_IR");
            private set => SetMemberString("fa_IR", value);
        }

        /// <summary>
        /// Leet Speak
        /// </summary>
        public string Fb_LT
        {
            get => GetMemberString("fb_LT");
            private set => SetMemberString("fb_LT", value);
        }

        /// <summary>
        /// Fula
        /// </summary>
        public string Ff_NG
        {
            get => GetMemberString("ff_NG");
            private set => SetMemberString("ff_NG", value);
        }

        /// <summary>
        /// Finnish
        /// </summary>
        public string Fi_FI
        {
            get => GetMemberString("fi_FI");
            private set => SetMemberString("fi_FI", value);
        }

        /// <summary>
        /// Faroese
        /// </summary>
        public string Fo_FO
        {
            get => GetMemberString("fo_FO");
            private set => SetMemberString("fo_FO", value);
        }

        /// <summary>
        /// French (Canada)
        /// </summary>
        public string Fr_CA
        {
            get => GetMemberString("fr_CA");
            private set => SetMemberString("fr_CA", value);
        }

        /// <summary>
        /// French (France)
        /// </summary>
        public string Fr_FR
        {
            get => GetMemberString("fr_FR");
            private set => SetMemberString("fr_FR", value);
        }

        /// <summary>
        /// Frisian
        /// </summary>
        public string Fy_NL
        {
            get => GetMemberString("fy_NL");
            private set => SetMemberString("fy_NL", value);
        }

        /// <summary>
        /// Irish
        /// </summary>
        public string Ga_IE
        {
            get => GetMemberString("ga_IE");
            private set => SetMemberString("ga_IE", value);
        }

        /// <summary>
        /// Galician
        /// </summary>
        public string Gl_ES
        {
            get => GetMemberString("gl_ES");
            private set => SetMemberString("gl_ES", value);
        }

        /// <summary>
        /// Guarani
        /// </summary>
        public string Gn_PY
        {
            get => GetMemberString("gn_PY");
            private set => SetMemberString("gn_PY", value);
        }

        /// <summary>
        /// Gujarati
        /// </summary>
        public string Gu_IN
        {
            get => GetMemberString("gu_IN");
            private set => SetMemberString("gu_IN", value);
        }

        /// <summary>
        /// Classical Greek
        /// </summary>
        public string Gx_GR
        {
            get => GetMemberString("gx_GR");
            private set => SetMemberString("gx_GR", value);
        }

        /// <summary>
        /// Hausa
        /// </summary>
        public string Ha_NG
        {
            get => GetMemberString("ha_NG");
            private set => SetMemberString("ha_NG", value);
        }

        /// <summary>
        /// Hebrew
        /// </summary>
        public string He_IL
        {
            get => GetMemberString("he_IL");
            private set => SetMemberString("he_IL", value);
        }

        /// <summary>
        /// Hindi
        /// </summary>
        public string Hi_IN
        {
            get => GetMemberString("hi_IN");
            private set => SetMemberString("hi_IN", value);
        }

        /// <summary>
        /// Croatian
        /// </summary>
        public string Hr_HR
        {
            get => GetMemberString("hr_HR");
            private set => SetMemberString("hr_HR", value);
        }

        /// <summary>
        /// Haitian Creole
        /// </summary>
        public string Ht_HT
        {
            get => GetMemberString("ht_HT");
            private set => SetMemberString("ht_HT", value);
        }

        /// <summary>
        /// Hungarian
        /// </summary>
        public string Hu_HU
        {
            get => GetMemberString("hu_HU");
            private set => SetMemberString("hu_HU", value);
        }

        /// <summary>
        /// Armenian
        /// </summary>
        public string Hy_AM
        {
            get => GetMemberString("hy_AM");
            private set => SetMemberString("hy_AM", value);
        }

        /// <summary>
        /// Indonesian
        /// </summary>
        public string Id_ID
        {
            get => GetMemberString("id_ID");
            private set => SetMemberString("id_ID", value);
        }

        /// <summary>
        /// Igbo
        /// </summary>
        public string Ig_NG
        {
            get => GetMemberString("ig_NG");
            private set => SetMemberString("ig_NG", value);
        }

        /// <summary>
        /// Icelandic
        /// </summary>
        public string Is_IS
        {
            get => GetMemberString("is_IS");
            private set => SetMemberString("is_IS", value);
        }

        /// <summary>
        /// Italian
        /// </summary>
        public string It_IT
        {
            get => GetMemberString("it_IT");
            private set => SetMemberString("it_IT", value);
        }

        /// <summary>
        /// Japanese
        /// </summary>
        public string Jp_JP
        {
            get => GetMemberString("jp_JP");
            private set => SetMemberString("jp_JP", value);
        }

        /// <summary>
        /// Japanese (Kansai)
        /// </summary>
        public string Jp_KS
        {
            get => GetMemberString("jp_KS");
            private set => SetMemberString("jp_KS", value);
        }

        /// <summary>
        /// Javanese
        /// </summary>
        public string Jv_ID
        {
            get => GetMemberString("jv_ID");
            private set => SetMemberString("jv_ID", value);
        }

        /// <summary>
        /// Georgian
        /// </summary>
        public string Ka_GE
        {
            get => GetMemberString("ka_GE");
            private set => SetMemberString("ka_GE", value);
        }

        /// <summary>
        /// Kazakh
        /// </summary>
        public string Kk_KZ
        {
            get => GetMemberString("kk_KZ");
            private set => SetMemberString("kk_KZ", value);
        }

        /// <summary>
        /// Khmer
        /// </summary>
        public string Km_KH
        {
            get => GetMemberString("km_KH");
            private set => SetMemberString("km_KH", value);
        }

        /// <summary>
        /// Kannada
        /// </summary>
        public string Kn_IN
        {
            get => GetMemberString("kn_IN");
            private set => SetMemberString("kn_IN", value);
        }

        /// <summary>
        /// Korean
        /// </summary>
        public string Ko_KR
        {
            get => GetMemberString("ko_KR");
            private set => SetMemberString("ko_KR", value);
        }

        /// <summary>
        /// Kashmiri
        /// </summary>
        public string Ks_IN
        {
            get => GetMemberString("ks_IN");
            private set => SetMemberString("ks_IN", value);
        }

        /// <summary>
        /// Kurdish (Kurmanji)
        /// </summary>
        public string Ku_TR
        {
            get => GetMemberString("ku_TR");
            private set => SetMemberString("ku_TR", value);
        }

        /// <summary>
        /// Kyrgyz
        /// </summary>
        public string Ky_KG
        {
            get => GetMemberString("ky_KG");
            private set => SetMemberString("ky_KG", value);
        }

        /// <summary>
        /// Latin
        /// </summary>
        public string La_VA
        {
            get => GetMemberString("la_VA");
            private set => SetMemberString("la_VA", value);
        }

        /// <summary>
        /// Ganda
        /// </summary>
        public string Lg_UG
        {
            get => GetMemberString("lg_UG");
            private set => SetMemberString("lg_UG", value);
        }

        /// <summary>
        /// Limburgish
        /// </summary>
        public string Li_NL
        {
            get => GetMemberString("li_NL");
            private set => SetMemberString("li_NL", value);
        }

        /// <summary>
        /// Lingala
        /// </summary>
        public string Ln_CD
        {
            get => GetMemberString("ln_CD");
            private set => SetMemberString("ln_CD", value);
        }

        /// <summary>
        /// Lao
        /// </summary>
        public string Lo_LA
        {
            get => GetMemberString("lo_LA");
            private set => SetMemberString("lo_LA", value);
        }

        /// <summary>
        /// Lithuanian
        /// </summary>
        public string Lt_LT
        {
            get => GetMemberString("lt_LT");
            private set => SetMemberString("lt_LT", value);
        }

        /// <summary>
        /// Latvian
        /// </summary>
        public string Lv_LV
        {
            get => GetMemberString("lv_LV");
            private set => SetMemberString("lv_LV", value);
        }

        /// <summary>
        /// Malagasy
        /// </summary>
        public string Mg_MG
        {
            get => GetMemberString("mg_MG");
            private set => SetMemberString("mg_MG", value);
        }

        /// <summary>
        /// Māori
        /// </summary>
        public string Mi_NZ
        {
            get => GetMemberString("mi_NZ");
            private set => SetMemberString("mi_NZ", value);
        }

        /// <summary>
        /// Macedonian
        /// </summary>
        public string Mk_MK
        {
            get => GetMemberString("mk_MK");
            private set => SetMemberString("mk_MK", value);
        }

        /// <summary>
        /// Malayalam
        /// </summary>
        public string Ml_IN
        {
            get => GetMemberString("ml_IN");
            private set => SetMemberString("ml_IN", value);
        }

        /// <summary>
        /// Mongolian
        /// </summary>
        public string Mn_MN
        {
            get => GetMemberString("mn_MN");
            private set => SetMemberString("mn_MN", value);
        }

        /// <summary>
        /// Marathi
        /// </summary>
        public string Mr_IN
        {
            get => GetMemberString("mr_IN");
            private set => SetMemberString("mr_IN", value);
        }

        /// <summary>
        /// Malay
        /// </summary>
        public string Ms_MY
        {
            get => GetMemberString("ms_MY");
            private set => SetMemberString("ms_MY", value);
        }

        /// <summary>
        /// Maltese
        /// </summary>
        public string Mt_MT
        {
            get => GetMemberString("mt_MT");
            private set => SetMemberString("mt_MT", value);
        }

        /// <summary>
        /// Burmese
        /// </summary>
        public string My_MM
        {
            get => GetMemberString("my_MM");
            private set => SetMemberString("my_MM", value);
        }

        /// <summary>
        /// Norwegian (bokmal)
        /// </summary>
        public string Nb_NO
        {
            get => GetMemberString("nb_NO");
            private set => SetMemberString("nb_NO", value);
        }

        /// <summary>
        /// Northern Ndebele
        /// </summary>
        public string Nd_ZW
        {
            get => GetMemberString("nd_ZW");
            private set => SetMemberString("nd_ZW", value);
        }

        /// <summary>
        /// Nepali
        /// </summary>
        public string Ne_NP
        {
            get => GetMemberString("ne_NP");
            private set => SetMemberString("ne_NP", value);
        }

        /// <summary>
        /// Dutch (België)
        /// </summary>
        public string Nl_BE
        {
            get => GetMemberString("nl_BE");
            private set => SetMemberString("nl_BE", value);
        }

        /// <summary>
        /// Dutch
        /// </summary>
        public string Nl_NL
        {
            get => GetMemberString("nl_NL");
            private set => SetMemberString("nl_NL", value);
        }

        /// <summary>
        /// Norwegian (nynorsk)
        /// </summary>
        public string Nn_NO
        {
            get => GetMemberString("nn_NO");
            private set => SetMemberString("nn_NO", value);
        }

        /// <summary>
        /// Southern Ndebele
        /// </summary>
        public string Nr_ZA
        {
            get => GetMemberString("nr_ZA");
            private set => SetMemberString("nr_ZA", value);
        }

        /// <summary>
        /// Northern Sotho
        /// </summary>
        public string Ns_ZA
        {
            get => GetMemberString("ns_ZA");
            private set => SetMemberString("ns_ZA", value);
        }

        /// <summary>
        /// Chewa
        /// </summary>
        public string Ny_MW
        {
            get => GetMemberString("ny_MW");
            private set => SetMemberString("ny_MW", value);
        }

        /// <summary>
        /// Oriya
        /// </summary>
        public string Or_IN
        {
            get => GetMemberString("or_IN");
            private set => SetMemberString("or_IN", value);
        }

        /// <summary>
        /// Punjabi
        /// </summary>
        public string Pa_IN
        {
            get => GetMemberString("pa_IN");
            private set => SetMemberString("pa_IN", value);
        }

        /// <summary>
        /// Polish
        /// </summary>
        public string Pl_PL
        {
            get => GetMemberString("pl_PL");
            private set => SetMemberString("pl_PL", value);
        }

        /// <summary>
        /// Pashto
        /// </summary>
        public string Ps_AF
        {
            get => GetMemberString("ps_AF");
            private set => SetMemberString("ps_AF", value);
        }

        /// <summary>
        /// Portuguese (Brazil)
        /// </summary>
        public string Pt_BR
        {
            get => GetMemberString("pt_BR");
            private set => SetMemberString("pt_BR", value);
        }

        /// <summary>
        /// Portuguese (Portugal)
        /// </summary>
        public string Pt_PT
        {
            get => GetMemberString("pt_PT");
            private set => SetMemberString("pt_PT", value);
        }

        /// <summary>
        /// Quiché
        /// </summary>
        public string Qc_GT
        {
            get => GetMemberString("qc_GT");
            private set => SetMemberString("qc_GT", value);
        }

        /// <summary>
        /// Quechua
        /// </summary>
        public string Qu_PE
        {
            get => GetMemberString("qu_PE");
            private set => SetMemberString("qu_PE", value);
        }

        /// <summary>
        /// Burmese (Zawgyi)
        /// </summary>
        public string Qz_MM
        {
            get => GetMemberString("qz_MM");
            private set => SetMemberString("qz_MM", value);
        }

        /// <summary>
        /// Romansh
        /// </summary>
        public string Rm_CH
        {
            get => GetMemberString("rm_CH");
            private set => SetMemberString("rm_CH", value);
        }

        /// <summary>
        /// Romanian
        /// </summary>
        public string Ro_RO
        {
            get => GetMemberString("ro_RO");
            private set => SetMemberString("ro_RO", value);
        }

        /// <summary>
        /// Russian
        /// </summary>
        public string Ru_RU
        {
            get => GetMemberString("ru_RU");
            private set => SetMemberString("ru_RU", value);
        }

        /// <summary>
        /// Kinyarwanda
        /// </summary>
        public string Rw_RW
        {
            get => GetMemberString("rw_RW");
            private set => SetMemberString("rw_RW", value);
        }

        /// <summary>
        /// Sanskrit
        /// </summary>
        public string Sa_IN
        {
            get => GetMemberString("sa_IN");
            private set => SetMemberString("sa_IN", value);
        }

        /// <summary>
        /// Sardinian
        /// </summary>
        public string Sc_IT
        {
            get => GetMemberString("sc_IT");
            private set => SetMemberString("sc_IT", value);
        }

        /// <summary>
        /// Northern Sámi
        /// </summary>
        public string Se_NO
        {
            get => GetMemberString("se_NO");
            private set => SetMemberString("se_NO", value);
        }

        /// <summary>
        /// Sinhala
        /// </summary>
        public string Si_LK
        {
            get => GetMemberString("si_LK");
            private set => SetMemberString("si_LK", value);
        }

        /// <summary>
        /// Slovak
        /// </summary>
        public string Sk_SK
        {
            get => GetMemberString("sk_SK");
            private set => SetMemberString("sk_SK", value);
        }

        /// <summary>
        /// Slovenian
        /// </summary>
        public string Sl_SI
        {
            get => GetMemberString("sl_SI");
            private set => SetMemberString("sl_SI", value);
        }

        /// <summary>
        /// Shona
        /// </summary>
        public string Sn_ZW
        {
            get => GetMemberString("sn_ZW");
            private set => SetMemberString("sn_ZW", value);
        }

        /// <summary>
        /// Somali
        /// </summary>
        public string So_SO
        {
            get => GetMemberString("so_SO");
            private set => SetMemberString("so_SO", value);
        }

        /// <summary>
        /// Albanian
        /// </summary>
        public string Sq_AL
        {
            get => GetMemberString("sq_AL");
            private set => SetMemberString("sq_AL", value);
        }

        /// <summary>
        /// Serbian
        /// </summary>
        public string Sr_RS
        {
            get => GetMemberString("sr_RS");
            private set => SetMemberString("sr_RS", value);
        }

        /// <summary>
        /// Swazi
        /// </summary>
        public string Ss_SZ
        {
            get => GetMemberString("ss_SZ");
            private set => SetMemberString("ss_SZ", value);
        }

        /// <summary>
        /// Southern Sotho
        /// </summary>
        public string St_ZA
        {
            get => GetMemberString("st_ZA");
            private set => SetMemberString("st_ZA", value);
        }

        /// <summary>
        /// Swedish
        /// </summary>
        public string Sv_SE
        {
            get => GetMemberString("sv_SE");
            private set => SetMemberString("sv_SE", value);
        }

        /// <summary>
        /// Swahili
        /// </summary>
        public string Sw_KE
        {
            get => GetMemberString("sw_KE");
            private set => SetMemberString("sw_KE", value);
        }

        /// <summary>
        /// Syriac
        /// </summary>
        public string Sy_SY
        {
            get => GetMemberString("sy_SY");
            private set => SetMemberString("sy_SY", value);
        }

        /// <summary>
        /// Silesian
        /// </summary>
        public string Sz_PL
        {
            get => GetMemberString("sz_PL");
            private set => SetMemberString("sz_PL", value);
        }

        /// <summary>
        /// Tamil
        /// </summary>
        public string Ta_IN
        {
            get => GetMemberString("ta_IN");
            private set => SetMemberString("ta_IN", value);
        }

        /// <summary>
        /// Telugu
        /// </summary>
        public string Te_IN
        {
            get => GetMemberString("te_IN");
            private set => SetMemberString("te_IN", value);
        }

        /// <summary>
        /// Tajik
        /// </summary>
        public string Tg_TJ
        {
            get => GetMemberString("tg_TJ");
            private set => SetMemberString("tg_TJ", value);
        }

        /// <summary>
        /// Thai
        /// </summary>
        public string Th_TH
        {
            get => GetMemberString("th_TH");
            private set => SetMemberString("th_TH", value);
        }

        /// <summary>
        /// Turkmen
        /// </summary>
        public string Tk_TM
        {
            get => GetMemberString("tk_TM");
            private set => SetMemberString("tk_TM", value);
        }

        /// <summary>
        /// Filipino
        /// </summary>
        public string Tl_PH
        {
            get => GetMemberString("tl_PH");
            private set => SetMemberString("tl_PH", value);
        }

        /// <summary>
        /// Klingon
        /// </summary>
        public string Tl_ST
        {
            get => GetMemberString("tl_ST");
            private set => SetMemberString("tl_ST", value);
        }

        /// <summary>
        /// Tswana
        /// </summary>
        public string Tn_BW
        {
            get => GetMemberString("tn_BW");
            private set => SetMemberString("tn_BW", value);
        }

        /// <summary>
        /// Turkish
        /// </summary>
        public string Tr_TR
        {
            get => GetMemberString("tr_TR");
            private set => SetMemberString("tr_TR", value);
        }

        /// <summary>
        /// Tsonga
        /// </summary>
        public string Ts_ZA
        {
            get => GetMemberString("ts_ZA");
            private set => SetMemberString("ts_ZA", value);
        }

        /// <summary>
        /// Tatar
        /// </summary>
        public string Tt_RU
        {
            get => GetMemberString("tt_RU");
            private set => SetMemberString("tt_RU", value);
        }

        /// <summary>
        /// Tamazight
        /// </summary>
        public string Tz_MA
        {
            get => GetMemberString("tz_MA");
            private set => SetMemberString("tz_MA", value);
        }

        /// <summary>
        /// Ukrainian
        /// </summary>
        public string Uk_UA
        {
            get => GetMemberString("uk_UA");
            private set => SetMemberString("uk_UA", value);
        }

        /// <summary>
        /// Urdu
        /// </summary>
        public string Ur_PK
        {
            get => GetMemberString("ur_PK");
            private set => SetMemberString("ur_PK", value);
        }

        /// <summary>
        /// Uzbek
        /// </summary>
        public string Uz_UZ
        {
            get => GetMemberString("uz_UZ");
            private set => SetMemberString("uz_UZ", value);
        }

        /// <summary>
        /// Venda
        /// </summary>
        public string Ve_ZA
        {
            get => GetMemberString("ve_ZA");
            private set => SetMemberString("ve_ZA", value);
        }

        /// <summary>
        /// Vietnamese
        /// </summary>
        public string Vi_VN
        {
            get => GetMemberString("vi_VN");
            private set => SetMemberString("vi_VN", value);
        }

        /// <summary>
        /// Wolof
        /// </summary>
        public string Wo_SN
        {
            get => GetMemberString("wo_SN");
            private set => SetMemberString("wo_SN", value);
        }

        /// <summary>
        /// Xhosa
        /// </summary>
        public string Xh_ZA
        {
            get => GetMemberString("xh_ZA");
            private set => SetMemberString("xh_ZA", value);
        }

        /// <summary>
        /// Yiddish
        /// </summary>
        public string Yi_DE
        {
            get => GetMemberString("yi_DE");
            private set => SetMemberString("yi_DE", value);
        }

        /// <summary>
        /// Yoruba
        /// </summary>
        public string Yo_NG
        {
            get => GetMemberString("yo_NG");
            private set => SetMemberString("yo_NG", value);
        }

        /// <summary>
        /// Simplified Chinese (China)
        /// </summary>
        public string Zh_CN
        {
            get => GetMemberString("zh_CN");
            private set => SetMemberString("zh_CN", value);
        }

        /// <summary>
        /// Traditional Chinese (Hong Kong)
        /// </summary>
        public string Zh_HK
        {
            get => GetMemberString("zh_HK");
            private set => SetMemberString("zh_HK", value);
        }

        /// <summary>
        /// Traditional Chinese (Taiwan)
        /// </summary>
        public string Zh_TW
        {
            get => GetMemberString("zh_TW");
            private set => SetMemberString("zh_TW", value);
        }

        /// <summary>
        /// Zulu
        /// </summary>
        public string Zu_ZA
        {
            get => GetMemberString("zu_ZA");
            private set => SetMemberString("zu_ZA", value);
        }

        /// <summary>
        /// Zazaki
        /// </summary>
        public string Zz_TR
        {
            get => GetMemberString("zz_TR");
            private set => SetMemberString("zz_TR", value);
        }
    }
}
