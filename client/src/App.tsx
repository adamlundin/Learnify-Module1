import React, { useEffect } from 'react';
import {Route, Switch} from 'react-router-dom';
import './sass/main.scss';
import Homepage from './pages/Homepage';
import LoginPage from './pages/Login';
import DetailPage from './pages/DetailPage';
import Navigation from './components/Navigation';
import "antd/dist/antd.min.css";
import Category from './components/Categories';
import CategoryPage from './pages/CategoryPage';
import DescriptionPage from './pages/DescriptionPage';
import BasketPage from './pages/BasketPage';
import { useAppDispatch } from './redux/store/configureStore';
import { fetchBasketAsync } from './redux/slice/basketSlice';
import Dashboard from './pages/Dashboard';
import { getUser } from './redux/slice/userSlice';

function App() {
  const dispatch = useAppDispatch();

  useEffect(() => {
    dispatch(fetchBasketAsync());
    dispatch(getUser());
  }, [dispatch]);

  return (
    <>
      <Navigation />
      <Route exact path="/" component={Category} />
      <Switch>
        <Route exact path="/" component={Homepage} />
        <Route exact path="/category/:id" component={CategoryPage} />
        <Route exact path="/basket" component={BasketPage} />
        <Route exact path="/course/:id" component={DescriptionPage} />
        <Route exact path="/login" component={LoginPage} />
        <Route exact path="/detail" component={DetailPage} />
        <Route exact path="/profile" component={Dashboard} />
      </Switch>
    </>
  );
};

export default App;
