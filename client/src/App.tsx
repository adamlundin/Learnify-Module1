import React from 'react';
import {Route, Switch} from 'react-router-dom';
import './sass/main.scss';
import Homepage from './pages/Homepage';
import LoginPage from './pages/Login';
import DetailPage from './pages/DetailPage';
import Navigation from './components/Navigation';
import "antd/dist/antd.min.css";
import Category from './components/Categories';
import CategoryPage from './pages/CategoryPage';

function App() {
  return (
    <>
      <Navigation />
      <Route exact path="/" component={Category} />
      <Switch>
        <Route exact path="/" component={Homepage} />
        <Route exact path="/category/:id" component={CategoryPage} />
        <Route exact path="/login" component={LoginPage} />
        <Route exact path="/detail" component={DetailPage} />
      </Switch>
    </>
  );
};

export default App;
