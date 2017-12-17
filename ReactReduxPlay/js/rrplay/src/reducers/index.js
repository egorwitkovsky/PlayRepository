const initialState = {
    account:{ name:'' }
}

export default (state=initialState, action) => {
    switch(action.type){
        case 'SET_ACCOUNT_DATA':
            return Object.assign({}, state, {account:action.payload});
        default:
            return state;
    }
}