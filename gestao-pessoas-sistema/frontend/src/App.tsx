import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Dashboard from './pages/Dashboard';
import Feedbacks from './pages/Feedbacks';
import Pdis from './pages/Pdis';

const App: React.FC = () => {
  return (
    <Router>
      <Switch>
        <Route path="/" exact component={Dashboard} />
        <Route path="/feedbacks" component={Feedbacks} />
        <Route path="/pdis" component={Pdis} />
      </Switch>
    </Router>
  );
};

export default App;