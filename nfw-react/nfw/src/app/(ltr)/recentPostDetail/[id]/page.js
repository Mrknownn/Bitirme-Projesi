"use client";
import RecentPostDetailPage from '../page'

const RecentPostDetail = ({ params }) => {


    if (params.id)
        return <RecentPostDetailPage id={params.id} />;
};

export default RecentPostDetail