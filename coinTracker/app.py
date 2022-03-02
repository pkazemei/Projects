from numpy import true_divide
import streamlit as st
import pandas as pd
import requests

# Load market data from Binance API
bnc = pd.read_json('https://api.binance.us/api/v3/ticker/24hr')

# Title
st.markdown('''# **Coin Tracker**
Here you can view all cryptos and add them to your favorites.
''')

st.header('**Favorites**')

# Defining columns for favorites
col1, col2, col3 = st.columns(3)

# Using sidebar to select coin
st.sidebar.header('**Edit Favorites**')
col1_selection = st.sidebar.selectbox('1', bnc.symbol, list(bnc.symbol).index('ONEUSD'))
col2_selection = st.sidebar.selectbox('2', bnc.symbol, list(bnc.symbol).index('AMPUSD'))
col3_selection = st.sidebar.selectbox('3', bnc.symbol, list(bnc.symbol).index('VETUSD'))
col4_selection = st.sidebar.selectbox('4', bnc.symbol, list(bnc.symbol).index('DOGEUSD'))
col5_selection = st.sidebar.selectbox('5', bnc.symbol, list(bnc.symbol).index('ZILUSD'))
col6_selection = st.sidebar.selectbox('6', bnc.symbol, list(bnc.symbol).index('DOTUSD'))
col7_selection = st.sidebar.selectbox('7', bnc.symbol, list(bnc.symbol).index('MANAUSD'))
col8_selection = st.sidebar.selectbox('8', bnc.symbol, list(bnc.symbol).index('BTCUSD'))
col9_selection = st.sidebar.selectbox('9', bnc.symbol, list(bnc.symbol).index('ETHUSD'))

# Coin selected based on user input
col1_bnc = bnc[bnc.symbol == col1_selection]
col2_bnc = bnc[bnc.symbol == col2_selection]
col3_bnc = bnc[bnc.symbol == col3_selection]
col4_bnc = bnc[bnc.symbol == col4_selection]
col5_bnc = bnc[bnc.symbol == col5_selection]
col6_bnc = bnc[bnc.symbol == col6_selection]
col7_bnc = bnc[bnc.symbol == col7_selection]
col8_bnc = bnc[bnc.symbol == col8_selection]
col9_bnc = bnc[bnc.symbol == col9_selection]

# Current price of coin selected based on user input
col1_price = (col1_bnc.lastPrice)
col2_price = (col2_bnc.lastPrice)
col3_price = (col3_bnc.lastPrice)
col4_price = (col4_bnc.lastPrice)
col5_price = (col5_bnc.lastPrice)
col6_price = (col6_bnc.lastPrice)
col7_price = (col7_bnc.lastPrice)
col8_price = (col8_bnc.lastPrice)
col9_price = (col9_bnc.lastPrice)

# Current price change of coin based on user input
col1_percent = f'{float(col1_bnc.priceChangePercent)}%'
col2_percent = f'{float(col2_bnc.priceChangePercent)}%'
col3_percent = f'{float(col3_bnc.priceChangePercent)}%'
col4_percent = f'{float(col4_bnc.priceChangePercent)}%'
col5_percent = f'{float(col5_bnc.priceChangePercent)}%'
col6_percent = f'{float(col6_bnc.priceChangePercent)}%'
col7_percent = f'{float(col7_bnc.priceChangePercent)}%'
col8_percent = f'{float(col8_bnc.priceChangePercent)}%'
col9_percent = f'{float(col9_bnc.priceChangePercent)}%'

# All keys shown in metrics boxes to show favorites
col1.metric(col1_selection, col1_price, col1_percent)
col2.metric(col2_selection, col2_price, col2_percent)
col3.metric(col3_selection, col3_price, col3_percent)
col1.metric(col4_selection, col4_price, col4_percent)
col2.metric(col5_selection, col5_price, col5_percent)
col3.metric(col6_selection, col6_price, col6_percent)
col1.metric(col7_selection, col7_price, col7_percent)
col2.metric(col8_selection, col8_price, col8_percent)
col3.metric(col9_selection, col9_price, col9_percent)

st.header("24hr Price Change % Amongst All Coins")
st.bar_chart(data= list(bnc.priceChangePercent), width=0, height=0, use_container_width=True)

# Defining markets
df=pd.DataFrame(bnc)
dfAll=df[['symbol', 'priceChange', 'priceChangePercent', 'lastPrice','quoteVolume']]

st.header('All Coin Data')
dfAll

st.markdown('##')
st.markdown('##')

st.info("""
Developed by: Paymon Kazemeini https://github.com/pkazemei
""") 

st.text('Source: Binance API https://api.binance.us/api/v3/ticker/24hr')

# to run, ctrl shift + C
# streamlit run app.py